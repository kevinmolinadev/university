package Complemento;

public class MainComplemento {
    public static void main(String[] args) {
        Estudiante estudiante=new Estudiante("Patito","19");
        Materia materia1=new Materia("Fisica",84);
        Materia materia2=new Materia("Algebra",64);
        Materia materia3=new Materia("Quimica",75);
        estudiante.setMaterias(materia1);
        estudiante.setMaterias(materia2);
        estudiante.setMaterias(materia3);
        estudiante.CalcularPromedio();
    }
}
