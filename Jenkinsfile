pipeline {
    agent any

    stages {
        stage('Clonar el Repo') {
            steps {
                git 'https://github.com/JohanC25/JCBurger.git'
            }
        }
        stage('Ejecutar Pruebas') {
            steps {    
                echo 'Compilando proyecto...'
            }
        }
    }
}
