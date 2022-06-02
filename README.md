# TagHelperJetBrainsAnnotationsSample

This repository is a sample for [ASP.NET Core Tag Helpers](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/intro?view=aspnetcore-6.0) together with the [JetBrains.Annotations package](https://www.nuget.org/packages/JetBrains.Annotations/).

JetBrains.Annotations provides code completion for the Tag Helper in [Rider](https://www.jetbrains.com/rider/) and [ReSharper](https://www.jetbrains.com/resharper/) for [TagHelperJetBrainsAnnotationsSample/Views/TagHelperSample/Index.cshtml](TagHelperJetBrainsAnnotationsSample/Views/TagHelperSample/Index.cshtml):

![img.png](assets/img.png)

![img_1.png](assets/img_1.png)

![img_2.png](assets/img_2.png)

It also recognizes not existing controllers and actions:

![img_3.png](assets/img_3.png)

## HTMX.TagHelpers and JetBrains.Annotations

However, when using [HTMX.TagHelpers](https://www.nuget.org/packages/Htmx.TagHelpers/), Code Completion inside the Tag Helper tags does not work using Rider or ReSharper (in [TagHelperJetBrainsAnnotationsSample/Views/HtmxSample/Index.cshtml](TagHelperJetBrainsAnnotationsSample/Views/HtmxSample/Index.cshtml).

![img4.png](assets/img4.png)