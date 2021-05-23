#setup
dotnet new -i "Fable.Template::*"
add .gitignore from some other fable project found online : https://raw.githubusercontent.com/ImaginaryDevelopment/Fable.Static/master/.gitignore
cd ./src
dotnet build
cd ..
dotnet tool restore
npm start

at this point the project should be up and running on 8080