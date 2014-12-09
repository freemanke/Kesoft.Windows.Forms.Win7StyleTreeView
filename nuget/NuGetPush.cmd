nuget update -self
nuget SetApiKey 11b952d1-5fa1-457c-adad-ec28a8c50bb4
nuget pack ..\sources\kesoft.windows.forms.win7styletreeview\kesoft.windows.forms.win7styletreeview.csproj
nuget push kesoft.windows.forms.win7styletreeview.*.nupkg