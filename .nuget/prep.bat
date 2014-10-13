rem
rem Prepare user account nuget for use
rem

rem
rem Add the 'corporate package source' - developer and build servers require this.
rem
rem 
nuget sources add -Name "BDSNugetPublic" -Source "http://majordomo.bds.com:8081/nexus/service/local/nuget/nuget-public/" -username "cdpMM5JW" -password "HuKKDuSIxYB4mSNmjLtF0k/Cu4fthRrc7Hh319BmCYva"

rem
rem Add the release repo source - only build servers require this
rem
nuget sources add -Name "BDSNugetRelease" -Source "http://majordomo.bds.com:8081/nexus/service/local/nuget/nuget-release/" -username "cdpMM5JW" -password "HuKKDuSIxYB4mSNmjLtF0k/Cu4fthRrc7Hh319BmCYva"


rem
rem Set the Nuget Release Repo as the default push source
rem
nuget config -set DefaultPushSource=http://majordomo.bds.com:8081/nexus/service/local/nuget/nuget-release/

rem
rem Set the APIKey for the default push source
rem
nuget setApiKey 5f2f7b21-6e37-3a83-ae79-7e29243b4356 -Source http://majordomo.bds.com:8081/nexus/service/local/nuget/nuget-release/


