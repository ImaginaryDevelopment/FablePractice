# setup

dotnet new -i "Fable.Template::*"
add .gitignore from some other fable project found online [https://raw.githubusercontent.com/ImaginaryDevelopment/Fable.Static/master/.gitignore](here)

```bat
cd ./src
dotnet build
cd ..
dotnet tool restore
npm start
```

at this point the project should be up and running on 8080

## preparing to add fable-react

```bat
dotnet tool install paket
paket init
```

create the paketadd.cmd file for convenience
I'm not sure if the --force was needed or not

```bat
paket convert-from-nuget --force
paketadd.cmd Fable.react
```

## Begin Fable's standard readme

## Fable Minimal App

This is a small Fable app project so you can easily get started and add your own code easily in it.

## Requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 3.0 or higher
* [node.js](https://nodejs.org) with [npm](https://www.npmjs.com/)
* An F# editor like Visual Studio, Visual Studio Code with [Ionide](http://ionide.io/) or [JetBrains Rider](https://www.jetbrains.com/rider/).

## Building and running the app

* Install JS dependencies: `npm install`
* Install F# dependencies: `npm start`
* After the first compilation is finished, in your browser open: http://localhost:8080/

Any modification you do to the F# code will be reflected in the web page after saving.

## Project structure

### npm

JS dependencies are declared in `package.json`, while `package-lock.json` is a lock file automatically generated.

### Webpack

[Webpack](https://webpack.js.org) is a JS bundler with extensions, like a static dev server that enables hot reloading on code changes. Fable interacts with Webpack through the `fable-loader`. Configuration for Webpack is defined in the `webpack.config.js` file. Note this sample only includes basic Webpack configuration for development mode, if you want to see a more comprehensive configuration check the [Fable webpack-config-template](https://github.com/fable-compiler/webpack-config-template/blob/master/webpack.config.js).

### F#

The sample only contains two F# files: the project (.fsproj) and a source file (.fs) in the `src` folder.

### Web assets

The `index.html` file and other assets like an icon can be found in the `public` folder.
