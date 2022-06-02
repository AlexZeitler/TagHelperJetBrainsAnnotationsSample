using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperJetBrainsAnnotationsSample.TagHelpers;

[HtmlTargetElement("*")]
public class MyUrlTagHelper : TagHelper
{
  [HtmlAttributeName("lx-controller")]
  [AspMvcController]
  public string? Controller { get; set; }

  [HtmlAttributeName("lx-view")]
  [AspMvcView]
  public string? View { get; set; }
  
  [HtmlAttributeName("lx-action")]
  [AspMvcAction]
  public string? Action { get; set; }
  
  [HtmlAttributeNotBound]
  [ViewContext]
  // ReSharper disable once UnusedAutoPropertyAccessor.Global
  public ViewContext? ViewContext { get; set; }

  public override void Process(
    TagHelperContext context,
    TagHelperOutput output
  )
  {
  }
  
  public MyUrlTagHelper(IHtmlGenerator generator)
  {
    Generator = generator;
  }

  /// <inheritdoc />
  public override int Order => -1000;

  /// <summary>
  /// Gets the <see cref="IHtmlGenerator"/> used to generate the <see cref="AnchorTagHelper"/>'s output.
  /// </summary>
  protected IHtmlGenerator Generator { get; }
}