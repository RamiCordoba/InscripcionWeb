using Microsoft.EntityFrameworkCore.Migrations;

namespace InscripcionWeb.Migrations
{
    public partial class Materias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "Id", "AñoCursadoId", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, 25, false, "Pedagogía" },
                    { 171, 15, false, "Didáctica de la Administración II" },
                    { 172, 15, false, "Sujetos de la Educación Secundaria" },
                    { 173, 15, false, "Práctica Docente III" },
                    { 174, 15, false, "Producción de los Recursos Didácticos I" },
                    { 175, 16, false, "Ética y Trabajo Docente" },
                    { 176, 16, false, "Educación Sexual Integral" },
                    { 177, 16, false, "UCCV Comunicación Social" },
                    { 178, 16, false, "Administración IV" },
                    { 179, 16, false, "Gestión Organizacional" },
                    { 180, 16, false, "Matemática Financiera" },
                    { 181, 16, false, "Prácticas de Investigación" },
                    { 182, 16, false, "Práctica Docente IV (Residencia)" },
                    { 183, 16, false, "Producción de los Recursos Didácticos II" },
                    { 184, 16, false, "Unidad de Definición Institucional" },
                    { 185, 17, false, "Psicología y Educación" },
                    { 186, 17, false, "Pedagogia" },
                    { 187, 17, false, "Sociología de la Educación" },
                    { 188, 17, false, "Historia Argentina y Latinoamericana(1º cuatr.)" },
                    { 189, 17, false, "Movimiento y Cuerpo I" },
                    { 190, 17, false, "Taller de Práctica I" },
                    { 191, 17, false, "Problemáticas Contemporáneas de la Educación Inicial I" },
                    { 192, 17, false, "Comunicación y Expresión Oral y Esctrita" },
                    { 193, 17, false, "Resolución de Problemas y Creatividad (1º cuatr.)" },
                    { 194, 17, false, "Ambiente y Sociedad (2º cuatr.)" },
                    { 195, 17, false, "Área Estético-Expresiva I" },
                    { 196, 17, false, "Itinerarios por el Mundo de la Cultura" },
                    { 197, 17, false, "Producción Pedagógica" },
                    { 198, 18, false, "Didáctica General" },
                    { 199, 18, false, "Filosofía de la Educación (1º cuatr.)" },
                    { 170, 15, false, "Derecho II" },
                    { 169, 15, false, "Práctica Impositiva y Laboral" },
                    { 168, 15, false, "Sistema de Información Contable III" },
                    { 167, 15, false, "Administración III" },
                    { 137, 9, false, "Ética y Responsabilidad Social" },
                    { 138, 9, false, "Legislación Laboral" },
                    { 139, 9, false, "Estrategia Empresarial" },
                    { 140, 9, false, "Sistema de Información para la Gestión de las Organizaciones " },
                    { 141, 9, false, "Gestión Financiera" },
                    { 142, 9, false, "Evaluación y Administración de Proyectos de Inversión" },
                    { 143, 9, false, "Control de Gestión" },
                    { 144, 9, false, "Practicas Profesionalizante II" },
                    { 145, 13, false, "Pedagogía" },
                    { 146, 13, false, "UCCV Sociología" },
                    { 147, 13, false, "Administración General" },
                    { 148, 13, false, "Administración I" },
                    { 149, 13, false, "Sistema de Información Contable I" },
                    { 150, 13, false, "Construcción de Ciudadanía" },
                    { 200, 18, false, "Conocimiento y Educación (2º cuatr.)" },
                    { 151, 13, false, "Historia Económica" },
                    { 153, 13, false, "Práctica Docente I" },
                    { 154, 14, false, "Instituciones Educativas" },
                    { 155, 14, false, "Didáctica y Curriculum" },
                    { 156, 14, false, "Psicología y Educación" },
                    { 157, 14, false, "Administración II" },
                    { 158, 14, false, "Sistema de Información Contable II" },
                    { 159, 14, false, "Derecho I" },
                    { 160, 14, false, "Economía" },
                    { 161, 14, false, "Estadística Aplicada" },
                    { 162, 14, false, "Didáctica de la Administración I" },
                    { 163, 14, false, "Práctica Docencia II" },
                    { 164, 15, false, "Historia y Política de la Educación Argentina " },
                    { 165, 15, false, "Filosofía" },
                    { 166, 15, false, "Metodología de la Investigación" },
                    { 152, 13, false, "Matemática" },
                    { 136, 9, false, "Gestión de Seguridad, Salud Ocupacional y Medio Ambiente" },
                    { 201, 18, false, "Movimiento y Cuerpo II" },
                    { 203, 18, false, "Sujeto de la Educación Inicial" },
                    { 238, 21, false, "Administración General" },
                    { 239, 21, false, "Matemática" },
                    { 240, 21, false, "Práctica Docente I" },
                    { 241, 22, false, "Instituciones Educativas" },
                    { 242, 22, false, "Didáctica y Curriculum" },
                    { 243, 22, false, "Psicología y Educación" },
                    { 244, 22, false, "Economía II" },
                    { 245, 22, false, "Sistema de Información Contable II" },
                    { 246, 22, false, "Derecho I" },
                    { 247, 22, false, "Economía" },
                    { 248, 22, false, "Estadística Aplicada" },
                    { 249, 22, false, "Didáctica de la Economía I" },
                    { 250, 22, false, "Práctica Docencia II" },
                    { 251, 23, false, "Historia y Política de la Educación Argentina" },
                    { 252, 23, false, "Filosofía" },
                    { 253, 23, false, "Metodología de la Investigación" },
                    { 254, 23, false, "Economía III" },
                    { 255, 23, false, "Finanzas Públicas" },
                    { 256, 23, false, "Derecho II" },
                    { 257, 23, false, "Sujetos de la Educación Secundaria " },
                    { 258, 23, false, "Práctica Docente III" },
                    { 259, 23, false, "Producción de los Recursos Didácticos I" },
                    { 260, 24, false, "Ética y Trabajo Docente" },
                    { 261, 24, false, "Educación Sexual Integral" },
                    { 262, 24, false, "UCCV Comunicación Social" },
                    { 263, 24, false, "Economía Social y Sostenible" },
                    { 264, 24, false, "Economía Argentina Latinoamericana e Internacional" },
                    { 265, 24, false, "Prácticas de Investigación" },
                    { 266, 24, false, "Práctica Docente IV (Residencia)" },
                    { 237, 21, false, "Sistema de Información Contable I" },
                    { 236, 21, false, "Construcción de Ciudadanía" },
                    { 235, 21, false, "Historia Económica" },
                    { 234, 21, false, "Geografía Económica" },
                    { 204, 18, false, "Didáctica de Educación Inicial I" },
                    { 205, 18, false, "Matemática y su Didáctica I" },
                    { 206, 18, false, "Literatura y su Didáctica" },
                    { 207, 18, false, "Ciencias Naturales y su Didáctica" },
                    { 208, 18, false, "Itinerarios por el Mundo de la Cultura" },
                    { 209, 18, false, "Producción Pedagógica" },
                    { 210, 19, false, "Tecnologías de la Información y de la Comunicación" },
                    { 211, 19, false, "Historia Social de la Educación y Política Educativa Argentina" },
                    { 212, 19, false, "Trayecto de Práctica III: Seminario de Instituciones Educativas" },
                    { 213, 19, false, "Matemática y su Didáctica II" },
                    { 214, 19, false, "Lengua y su Didáctica (1º cuatr.)" },
                    { 215, 19, false, "Alfabetización Inicial (2º cuatr.)" },
                    { 216, 19, false, "Ciencias Sociales y su Didáctica" },
                    { 217, 19, false, "Área Estético-Expresiva II" },
                    { 202, 18, false, "Taller de Práctica II: Seminario de lo Grupal y los Grupos de Aprendizaje" },
                    { 218, 19, false, "Problemáticas Contemporáneas de la Educación Inicial II (1º cuatr.)" },
                    { 220, 19, false, "Espacios de Definición Institucional (1º cuatr.)" },
                    { 221, 19, false, "Espacios de Definición Institucional (2º cuatr.)" },
                    { 222, 19, false, "Itinerarios por el Mundo de la Cultura" },
                    { 223, 19, false, "Producción Pedagógica" },
                    { 224, 20, false, "Ética, Trabajo Docente, Derechos Humanos y Ciudadanos" },
                    { 225, 20, false, "Taller de Práctica IV" },
                    { 226, 20, false, "Ateneo: (Matemática- Ambiente y Sociedad (Ciencias Naturales- Ciencias Sociales) Lengua y Literatura- Formación Ètica y Ciudadana)" },
                    { 227, 20, false, "Sexualidad Humana y Educación  (1º cuatr.)" },
                    { 228, 20, false, "Itinerarios por el Mundo de la Cultura" },
                    { 229, 20, false, "Producción Pedagógica" },
                    { 230, 21, false, "Pedagogía" },
                    { 231, 21, false, "UCCV Sociología" },
                    { 232, 21, false, "Administración General" },
                    { 233, 21, false, "Economía I" },
                    { 219, 19, false, "Didáctica de la Educación Inicial II (2º cuatr.)" },
                    { 135, 8, false, "Práctica Profesionalizante I" },
                    { 134, 8, false, "Gestión Contable" },
                    { 133, 8, false, "Gestión de Costos" },
                    { 36, 28, false, "Biotecnología " },
                    { 37, 28, false, "Procesos de Comunicación " },
                    { 38, 28, false, "Problemáticas Sociotécnicas " },
                    { 39, 28, false, "Diseño y Producción Tecnológica IV" },
                    { 40, 28, false, "Taller de Producción Didáctica" },
                    { 41, 10, false, "Comunicación" },
                    { 42, 10, false, "Unidad de Definición Institucional I" },
                    { 43, 10, false, "Salud Pública" },
                    { 44, 10, false, "Biología Humana I" },
                    { 45, 10, false, "Sujeto, Cultura y Sociedad I" },
                    { 46, 10, false, "Fundaméntos del Cuidado en Enfermería" },
                    { 47, 10, false, "Cuidados de Enfermería en la Comunidad y en la Familia" },
                    { 48, 10, false, "Práctica Profesionalizante I" },
                    { 49, 11, false, "Problemáticas Socio Contemporáneas" },
                    { 50, 11, false, "Unidad de Definición Institucional II" },
                    { 51, 11, false, "Informática en Salud" },
                    { 52, 11, false, "Sujeto, Cultura y Sociedad II" },
                    { 53, 11, false, "Biología Humana II" },
                    { 54, 11, false, "Bioseguridad y Medio Ambiente en el Trabajo" },
                    { 55, 11, false, "Farmacología en Enfermería" },
                    { 56, 11, false, "Cuidados de Enfermería a los Adultos y Adultos Mayores" },
                    { 57, 11, false, "Práctica Profesionalizante II" },
                    { 58, 12, false, "Ética y Responsabilidad Social" },
                    { 59, 12, false, "Derecho y Legislación Laboral" },
                    { 60, 12, false, "Inglés Técnico" },
                    { 61, 12, false, "Organización y Gestión en Instituciones de Salud" },
                    { 62, 12, false, "Investigación en Enfermería" },
                    { 63, 12, false, "Cuidados de Enfermería en Salud Mental" },
                    { 64, 12, false, "Cuidados de Enfermería al Niño y al Adolescente" },
                    { 35, 28, false, "Práctica Docente IV: El Rol Docente y su Práctica" },
                    { 34, 28, false, "Prácticas de Investigación" },
                    { 33, 28, false, "Unidades de Definición Institucional II" },
                    { 32, 28, false, "Unidades de Definición Institucional I" },
                    { 2, 25, false, "Movimiento y Cuerpo" },
                    { 3, 25, false, "Práctica Docente I: Escenarios Educativos" },
                    { 4, 25, false, "Introducción a la Tecnología" },
                    { 5, 25, false, "Historia de la Tecnología" },
                    { 6, 25, false, "Diseño y Producción de la Técnología 1" },
                    { 7, 25, false, "Matemática" },
                    { 8, 25, false, "Física" },
                    { 9, 26, false, "Psicología de la Educación" },
                    { 10, 26, false, "Didáctica y Curriculum" },
                    { 11, 26, false, "Instituciones Educativas" },
                    { 12, 26, false, "Práctica Docente II: La Institución Escolar" },
                    { 13, 26, false, "Sujetos de la Educación I" },
                    { 14, 26, false, "Tic para la Enseñanza" },
                    { 15, 26, false, "Procesos Productivos" },
                    { 65, 12, false, "Práctica Profesionalizante III" },
                    { 16, 26, false, "Tecnológica II" },
                    { 18, 27, false, "Filosofía y Educación" },
                    { 19, 27, false, "Historia Social de la Educación" },
                    { 20, 27, false, "Metodología de la Investigación" },
                    { 21, 27, false, "Práctica Docente III: La Clase" },
                    { 22, 27, false, "Sujetos de la Educación II" },
                    { 23, 27, false, "Materiales" },
                    { 24, 27, false, "Química " },
                    { 25, 27, false, "Procesos de Control" },
                    { 26, 27, false, "Tecnologías Regionales " },
                    { 27, 27, false, "Diseño y Producción" },
                    { 28, 27, false, "Tecnológica III" },
                    { 29, 27, false, "Didáctica Específica II" },
                    { 30, 28, false, "Ética y Trabajo Docente" },
                    { 31, 28, false, "Educación Sexual Integral" },
                    { 17, 26, false, "Didáctica Específica I" },
                    { 66, 4, false, "Comunicación (1° cuat.)" },
                    { 67, 4, false, "Unidad de definición Institucional (2° cuat.)" },
                    { 68, 4, false, "Matemática" },
                    { 103, 2, false, "Inglés Técnico II" },
                    { 104, 2, false, "Innovación y Desarrollo Emprendedor" },
                    { 105, 2, false, "Estadística" },
                    { 106, 2, false, "Programación I" },
                    { 107, 2, false, "Ingeniería de Software II" },
                    { 108, 2, false, "Base de Datos I" },
                    { 109, 2, false, "Práctica Profesionalizante I" },
                    { 110, 3, false, "Ética y Responsabilidad Social" },
                    { 111, 3, false, "Derecho y Legislación Laboral " },
                    { 112, 3, false, "Redes y Comunicación" },
                    { 113, 3, false, "Programación II" },
                    { 114, 3, false, "Gestión de Proyectos de Software" },
                    { 115, 3, false, "Base de Datos II" },
                    { 116, 3, false, "Práctica Profesionalizante II" },
                    { 102, 2, false, "Unidad de definición Institucional (2° cuat.)" },
                    { 117, 7, false, "Comunicación (1° cuat.)" },
                    { 119, 7, false, "Economía " },
                    { 120, 7, false, "Matemática y Estadística" },
                    { 121, 7, false, "Contabilidad" },
                    { 122, 7, false, "Informática " },
                    { 123, 7, false, "Administración " },
                    { 124, 7, false, "Gestión de la Producción " },
                    { 125, 7, false, "Gestión del Talento " },
                    { 126, 7, false, "Humano" },
                    { 127, 8, false, "Problemáticas Contemporáneas" },
                    { 128, 8, false, "Unidad de Definición Institucional II (2° cuat.)" },
                    { 129, 8, false, "Innovación y Desarrollo Emprendedor" },
                    { 130, 8, false, "Inglés Técnico" },
                    { 131, 8, false, "Legislación Comercial y Tributaria " },
                    { 132, 8, false, "Gestión de Comercialización e Investigación Comercia" },
                    { 118, 7, false, "Unidad de Definición Institucional (2° cuat.)" },
                    { 267, 24, false, "Producción de los Recursos Didácticos II" },
                    { 101, 2, false, "Problemáticas Socio Contemporáneas (1° cuat.)" },
                    { 99, 1, false, "Ingeniería de Software I" },
                    { 69, 4, false, "Física Aplicada a las Tecnologías de la Información" },
                    { 70, 4, false, "Administración" },
                    { 71, 4, false, "Inglés Técnico" },
                    { 72, 4, false, "Arquitectura de las Computadoras" },
                    { 73, 4, false, "Lógica y Programación" },
                    { 74, 4, false, "Infraestructura de Redes I" },
                    { 75, 5, false, "Problemáticas Socio Contemporáneas (1° cuat.)" },
                    { 76, 5, false, "Unidad de definición Institucional (2° cuat.)" },
                    { 77, 5, false, "Innovación y Desarrollo Emprendedor" },
                    { 78, 5, false, "Estadística" },
                    { 79, 5, false, "Sistemas Operativos" },
                    { 80, 5, false, "Algoritmos y Estructuras de Datos" },
                    { 81, 5, false, "Base de Datos" },
                    { 82, 5, false, "Infraestructura de Datos II" },
                    { 100, 1, false, "Sistemas Operativos" },
                    { 83, 5, false, "Práctica Profesionalizante I" },
                    { 85, 6, false, "Derecho y Legislación Laboral" },
                    { 86, 6, false, "Administración de Base de Datos" },
                    { 87, 6, false, "Integridad y Migración de Datos" },
                    { 88, 6, false, "Seguridad de los Sistemas" },
                    { 89, 6, false, "Administración de Sistemas" },
                    { 90, 6, false, "Operativos y Redes" },
                    { 91, 6, false, "Práctica Profesionalizante II" },
                    { 92, 1, false, "Comunicación (1° cuat.)" },
                    { 93, 1, false, "Unidad de definición Institucional (2° cuat.)" },
                    { 94, 1, false, "Matemática" },
                    { 95, 1, false, "Inglés Técnico I" },
                    { 96, 1, false, "Administración" },
                    { 97, 1, false, "Tecnología de la Información" },
                    { 98, 1, false, "Lógica y Estructura de Datos" },
                    { 84, 6, false, "Ética y Responsabilidad Social" },
                    { 268, 24, false, "Unidad de Definición Institucional" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 268);
        }
    }
}
