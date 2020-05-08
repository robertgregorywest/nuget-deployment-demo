# NuGetDeploymentDemo
A demonstration of continuous deployment using Azure DevOps and GitVersion.

GitVersion is used to automatically set the NuGet package version. The configuration is for GitHubFlow approach. Any feature branch will trigger a build with an alpha suffix, commits to master will increment version.
