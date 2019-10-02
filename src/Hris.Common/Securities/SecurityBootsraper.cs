using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Common.Securities
{
    public static class SecurityBootsraper
    {
        public static void InitSecurityBootsraper(this IApplicationBuilder app)
        {
            //This prevents pages from loading in modern browsers when reflected cross - site scripting is detected.This is often unnecessary if a site implements a strong Content - Security - Policy.
             app.UseXXssProtection(opts => opts.EnabledWithBlockMode());
            //This header ensures that site content is not being embedded in an iframe on other sites - used to avoid clickjacking attacks.            
            app.UseXfo(opts => opts.SameOrigin());
            //[CSP] Content-Security-Policy Header Basically, the Content-Security - Policy header allows you to whitelist resource origins when the site is loaded.
            app.UseCsp(opts => opts
                .BlockAllMixedContent()
                .StyleSources(x => x.Self())
                .StyleSources(x => x.UnsafeInline())
                .FontSources(x => x.Self())
                .FormActions(x => x.Self())
                .FrameAncestors(x => x.Self())
                .ImageSources(x => x.Self())
                .ScriptSources(x => x.Self()));

            //X - Content - Type - Options Header, Attackers are very smart.They can change an innocent MIME type(e.g.text / css) into something that could be executable. This could make some real damage.
            app.UseXContentTypeOptions();
            //Referrer - Policy Http Reader This header tells the site how much information to send along in the Referrer header field.
            app.UseReferrerPolicy(opts => opts.NoReferrer());
        }      
    }
}
