using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Constants;

public static class AuthMessages
{
    public const string EmailAuthenticatorDontExists = "E-posta kimlik doğrulayıcısı mevcut değil.";
    public const string OtpAuthenticatorDontExists = "Otp kimlik doğrulayıcısı mevcut değil.";
    public const string AlreadyVerifiedOtpAuthenticatorIsExists = "Otp kimlik doğrulayıcısı zaten var.";
    public const string EmailActivationKeyDontExists = "E-posta aktivasyon anahtarı yok.";
    public const string UserDontExists = "Böyle bir kullanıcı yok.";
    public const string UserHaveAlreadyAAuthenticator = "Kullanıcının zaten bir kimlik doğrulayıcısı var.";
    public const string RefreshDontExists = "Yenileme mevcut değil.";
    public const string InvalidRefreshToken = "Geçersiz yenileme jetonu(hash).";
    public const string UserMailAlreadyExists = "Bu kullanıcının e-postası zaten var.";
    public const string PasswordDontMatch = "Şifreler uyuşmuyor.";
}