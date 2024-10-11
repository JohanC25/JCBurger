pipeline {
    agent any

    stages {
        stage('Clone Repository') {
            steps {
                git 'https://github.com/JohanC25/JCBurger.git'
            }
        }
        stage('Build/Run Tests') {
            steps {    
                echo 'Compilando proyecto...'
            }
        }
    }
}
