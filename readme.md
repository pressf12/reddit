REDDIT C# API
=================

This API is a client for http://www.reddit.com

To get started -- have a look at the unit tests in com.reddit.tests, make sure you create an app.config 
file with the following keys setup.

``` xml

<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="username" value="your-username" />
    <add key="password" value="your-password" />
  </appSettings>
</configuration>

```

To understand the API more have a look at https://github.com/reddit/reddit/wiki/API.