# Just Another Boring Blog - Net Core Piranha CMS

No tutorial, just some notes

## Getting Started

The main idea for this readme, is just a reminder for myself (in future), when I forgot how to install this website...

## Built With

By now, March 2019, this are the current settings to get boring site running...

* [.NET Core 2.2.105](https://dotnet.microsoft.com/download)
* [Jenkins 2.164.1](https://jenkins.io/download/)
* [Domain from Freenom](https://www.freenom.com/en/index.html?lang=en)
* [SmarterASP.NET Hosting](https://www.smarterasp.net/)

### Installing

Just follow instructions from [Pirahna CMS](http://piranhacms.org/) for install blog basic template (by now .Net Core are already installed):

Create folder for project:

```
mkdir PiranhaBoringBlog
cd PiranhaBoringBlog
```

Install templates for Piranha CMS:

```
dotnet new -i Piranha.BasicWeb.CSharp
dotnet new -i Piranha.Blog.CSharp
```

Create project:

```
dotnet new piranha
dotnet restore
dotnet run
```

Test site http://localhost:5000/, actually they have an option to popuplate with example data for get more easy step by step:
```
http://localhost:5000/seed
```
Initial user and pass to backend manager, backoffice, or whatever that was:
```
http://localhost:5000/manager
username : admin
password : password
```

## Deployment 

Publish web site:

```
dotnet publish
```

## Acknowledgments

* Pirahna CMS for make things simple
* .Net Core for be a good option
* To myself from the past(note for mee on the future) to get the time to start from something simple
