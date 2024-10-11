pipeline {
    agent any

    stages {
        stage('Clone Repository') {
            steps {
                git 'https://github.com/usuario/repo.git'
            }
        }
        stage('Build/Run Tests') {
            steps {    
                echo 'Compilando proyecto...'
            }
        }
    }
}
