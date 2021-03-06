# Google.Devtools.AspNet

`Google.Devtools.AspNet` is an ASP.NET instrumentation library for Google Stackdriver.
It allows for simple integration of Stackdriver into ASP.NET applications with minimal code changes.

`Google.Devtools.AspNet` currently supports Stackdriver Error Reporting.

# Installation

Install the `Google.Devtools.AspNet` package from our
[early access MyGet
feed](https://www.myget.org/gallery/google-dotnet-public).
First configure your environment to include the appropriate NuGet feed
URL:

- NuGet v2: `https://www.myget.org/F/google-dotnet-public/`
- NuGet v3: `https://www.myget.org/F/google-dotnet-public/api/v3/index.json`

Next, add the package to your project in the normal way (for example
by right-clicking on the project in Visual Studio and choosing
"Manage NuGet Packages..."). Please ensure you enable pre-release
packages (for example, in the Visual Studio NuGet user interface,
check the "Include prerelease" box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth login
```

# Getting started

## Registering error Reporting

[!code-cs[](obj/snippets/Google.Devtools.AspNet.AspNet.txt#RegisterExceptionLogger)]
