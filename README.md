# NumericSequenceCalculator


Datebase
    1.Install RedGate Source Control
    2.Create one new database "NSC_DB"
    3.Create one new user "NSC_User" "Pa$$word"
    3.Link new database to this folder: \Solution\Database\SourceControl\
    4.Get the latest changes
    5.Run dummydata scripts in folder: \Solution\Database\DummyData\ 

WebAPI
    Local: http://localhost/NCS.WebAPI/swagger/ui/index
    DevInt:
    UAT: http://ncs-webapi.azurewebsites.net/swagger/ui/index
    Production:

Web
    Local: http://localhost/NCS.Web
    DevInt:
    UAT:
    Production:

Development (CD)
    Model -> Nuget
    WebApi -> Nuget
    Web -> Azure
    
