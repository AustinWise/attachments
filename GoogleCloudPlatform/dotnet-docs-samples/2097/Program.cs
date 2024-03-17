using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;

string aud = "/projects/72643967898/global/backendServices/1079754107036193628";

var token = await GetOidcTokenAsync(aud, default);
var tokenStr = await token.GetAccessTokenAsync();

var res = await new IAPTokenVerification().VerifyTokenAsync(tokenStr, aud);

Console.WriteLine(res.Subject);

static async Task<OidcToken> GetOidcTokenAsync(string iapClientId, CancellationToken cancellationToken)
{
    // Obtain the application default credentials.
    GoogleCredential credential = await GoogleCredential.GetApplicationDefaultAsync(cancellationToken);

    if (credential.UnderlyingCredential is not IOidcTokenProvider)
    {
        // If we are running on our developer machine, impersonate the service identity.
        credential = credential.Impersonate(new ImpersonatedCredential.Initializer("test-service-account@test-iap-379718.iam.gserviceaccount.com"));
    }

    // Request an OIDC token for the Cloud IAP-secured client ID.
    return await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience(iapClientId), cancellationToken);
}

public class IAPTokenVerification
{
    public async Task<JsonWebSignature.Payload> VerifyTokenAsync(
        string signedJwt, string expectedAudience, CancellationToken cancellationToken = default)
    {
        SignedTokenVerificationOptions options = new SignedTokenVerificationOptions
        {
            // Use clock tolerance to account for possible clock differences
            // between the issuer and the verifier.
            IssuedAtClockTolerance = TimeSpan.FromMinutes(1),
            ExpiryClockTolerance = TimeSpan.FromMinutes(1),
            TrustedAudiences = { expectedAudience },
            //TrustedIssuers = { "https://cloud.google.com/iap" },
            //CertificatesUrl = GoogleAuthConsts.IapKeySetUrl,
        };

        return await JsonWebSignature.VerifySignedTokenAsync(signedJwt, options, cancellationToken: cancellationToken);
    }
}
