pipeline {
  agent {
    docker {
      label 'docker'
      image 'microsoft/dotnet'
    }
  }
  stages {
    stage('Build') {
      when {
        branch 'master'
      }
      environment {
        BINTRAY = credentials('fint-bintray')
      }
      steps {
        sh 'git clean -fdx'
        sh 'dotnet restore -s https://api.bintray.com/nuget/fint/nuget'
        sh 'dotnet build -c Release'
        sh 'dotnet pack -c Release'
        archiveArtifacts '**/*.nupkg'
        sh "dotnet nuget push FINT.Model.Felles/bin/Release/FINT.Model.Felles.*.nupkg -k ${BINTRAY} -s https://api.bintray.com/nuget/fint/nuget"
      }
    }
  }
}
