use practica_tres_registro;

CREATE TABLE Estudiante (
    id_est INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    apellido VARCHAR(255) NOT NULL
);

CREATE TABLE Asignatura (
    id_asig INT IDENTITY(1,1) PRIMARY KEY,
    materia VARCHAR(255) NOT NULL,
    docente VARCHAR(255) NOT NULL,
    id_estudiante INT NOT NULL,
    FOREIGN KEY (id_estudiante) REFERENCES Estudiante(id_est)
);

CREATE TABLE Notas (
    id_notas INT IDENTITY(1,1) PRIMARY KEY,
    nota_primer INT NOT NULL,
    nota_seg INT NOT NULL,
    nota_exfinal INT NOT NULL,
    id_estudiante INT NOT NULL,
    id_asignatura INT NOT NULL,
    FOREIGN KEY (id_estudiante) REFERENCES Estudiante(id_est),
    FOREIGN KEY (id_asignatura) REFERENCES Asignatura(id_asig)
);

  --Insert de prueba
--INSERT INTO Estudiante (nombre, apellido)
--VALUES ('Juan', 'Pérez');

--INSERT INTO Asignatura (materia, docente, id_estudiante)
--VALUES ('Matemáticas', 'Elvis', 1);

--INSERT INTO Notas (nota_primer, nota_seg, nota_exfinal, id_estudiante, id_asignatura)
--VALUES (90, 85, 95, 1, 1);