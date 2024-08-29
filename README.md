# Data Science with .NET and Polyglot Notebooks

<a href="https://www.packtpub.com/en-us/product/data-science-with-net-and-polyglot-notebooks-9781835882962?utm_source=github&utm_medium=repository&utm_campaign="><img src="https://content.packt.com/_/image/original/B22115/cover_image_large.jpg" alt="Data Science with .NET and Polyglot Notebooks" height="256px" align="right"></a>

This is the code repository for [Data Science with .NET and Polyglot Notebooks](https://www.packtpub.com/en-us/product/data-science-with-net-and-polyglot-notebooks-9781835882962?utm_source=github&utm_medium=repository&utm_campaign=), published by Packt.

**Programmer’s guide to data science using ML.NET, OpenAI, and Semantic Kernel**

## What is this book about?
As the fields of data science, machine learning, and artificial intelligence rapidly evolve, .NET developers are eager to leverage their expertise to dive into these exciting domains but are often unsure of how to do so. Data Science in .NET with Polyglot Notebooks is the practical guide you need to seamlessly bring your .NET skills into the world of analytics and AI.

This book covers the following exciting features:
* Load, analyze, and transform data using DataFrames, data visualization, and descriptive statistics
* Train machine learning models with ML.NET for classification and regression tasks
* Customize ML.NET model training pipelines with AutoML, transforms, and model trainers
* Apply best practices for deploying models and monitoring their performance
* Connect to generative AI models using Polyglot Notebooks
* Chain together complex AI tasks with AI orchestration, RAG, and Semantic Kernel
* Create interactive online documentation with Mermaid charts and GitHub Codespaces

If you feel this book is for you, get your [copy](https://www.amazon.com/dp/1835882978) today!

<a href="https://www.packtpub.com/?utm_source=github&utm_medium=banner&utm_campaign=GitHubBanner"><img src="https://raw.githubusercontent.com/PacktPublishing/GitHub/master/GitHub.png" 
alt="https://www.packtpub.com/" border="5" /></a>

## Instructions and Navigations
All of the code is organized into folders.

The code will look like the following:
```
ExperimentResult<MulticlassClassificationMetrics> result =
 exp.Execute(split.TrainSet, split.TestSet);
ITransformer model = result.BestRun.Model;
var metrics = result.BestRun.ValidationMetrics;
metrics.ConfusionMatrix.GetFormattedConfusionTable()
```

**Following is what you need for this book:**
This book is for experienced C# or F# developers who want to transition into data science and machine learning while leveraging their .NET expertise. It’s ideal for those looking to learn ML.NET and Semantic kernel and extend their .NET skills to data science, machine learning, and Generative AI Workflows.

With the following software and hardware list you can run all code files present in the book (Chapter 1-14).
### Software and Hardware List
| Chapter | Software required | OS required |
| -------- | ------------------------------------ | ----------------------------------- |
| 1-14 |  VS Code | Windows, Mac OS X, and Linux (Any) |
| 1-14 |  .NET (C# and some F#) | Windows, Mac OS X, and Linux (Any) |
| 1-14 |  ML.NET | Windows, Mac OS X, and Linux (Any) |
| 1-14 |  Other languages covered in brief: PowerShell, SQL, and KQL | Windows, Mac OS X, and Linux (Any) |

### Related products
* Building AI Applications with ChatGPT APIs: Master ChatGPT, Whisper, and DALL-E APIs by building ten innovative AI projects [[Packt]](https://www.packtpub.com/en-us/product/building-ai-applications-with-chatgpt-apis-9781805127567?utm_source=github&utm_medium=repository&utm_campaign=9781839216862) [[Amazon]](https://www.amazon.com/dp/180512756X)

* The AI Product Manager's Handbook: Develop a product that takes advantage of machine learning to solve AI problems [[Packt]](https://www.packtpub.com/en-us/product/the-ai-product-managers-handbook-9781804612934?utm_source=github&utm_medium=repository&utm_campaign=9781803239545) [[Amazon]](https://www.amazon.com/dp/1804612936)

## Get to Know the Author
**Matt Eland**
is a software engineering leader and data scientist who has been using .NET since beta 2 in 2001. Matt has served as a senior engineer, software engineering manager, professional programming instructor, and has helped build enterprise-level software using C# at a variety of organisations before distinguishing himself as a Microsoft MVP.
Matt makes it his job to learn new things and share them with others through articles, videos, and talks at user groups and conferences covering a wide range of topics from software architecture to advanced .NET topics to artificial intelligence and data science. Matt is also a .NET Foundation member and the co-organizer of the Central Ohio .NET Developers Group.
