using Microsoft.AspNetCore.Razor.TagHelpers;

namespace YSKProje.UdemiyToDo.Web.TagHelpers
{
    [HtmlTargetElement("besir")]
      public class Paragraf : TagHelper
    {
        public string GelenData { get; set; } = "beşiir aydemir";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //string data
            //tagBuilder
            //stringtagBuilder

            //<p> <p>Beşir aydemir</></prop>

            //var tagbulder = new TagBuilder("p");
            //TagBuilder.innerHtml.AppendHtml("<b>beşir aydemir<b>")
            //output.Content.SetHtmlContentContent(TagBuilder)

            string data = string.Empty;
            data = "<p><b>"+ GelenData + "</b></p>";
            output.Content.SetHtmlContent(data);
                base.Process(context, output);
        }
    }
}
