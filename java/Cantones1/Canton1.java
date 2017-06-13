import java.util.*;
/**
 * Write a description of class Canton1 here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Canton1
{
    // instance variables - replace the example below with your own
    private String canton;
    private List<Persona> persona;
    private int promedioM;
    private int promedioH;
    private int promedioTotal;
    private double porcentajePersona;

    /**
     * Constructor for objects of class Canton1
     */
    public Canton1(String canton)
    {
        // initialise instance variables
        this.canton = canton;
        persona = new ArrayList<Persona>();
        this.promedioTotal=0;
        this.promedioM=0;
        this.promedioH=0;
        this.porcentajePersona=0;
    }
    /*
     * Agregar Persona
     */
    public void AddPersona(Persona nuevaPersona)
    {
        persona.add(nuevaPersona);
    }
    public int numberOfPerson()
    {  
        return persona.size();
    }
    public void printList()
    {
      if(numberOfPerson()>0)
      {
           System.out.println("Nombre--Genero--Edad--Trabaja");
            System.out.println(" ");
           for (Persona b : persona)
           {
               System.out.println(b.getNombre()+"--"+b.getSexo() +"--"+ b.getEdad()+"--"+b.getTrabaja());
           }
      }
      else{
           System.out.println("Agregue Personas Al Canton");
      }
    }
    public void CalcularPromedioEdad()
    {
        if(numberOfPerson()>0)
        {
            int sumM=0,sumH=0,cantM=0,cantH=0,sumaTotal=0;
            for(Persona p : persona)
            {
                if(p.getSexo() == true)
                {
                    sumM += p.getEdad();
                    cantM++;
                }
                else{
                    sumH += p.getEdad();
                    cantH++;
                }
                sumaTotal += p.getEdad();
            }
            printList();
            System.out.println("---------------------------------------------");
            if(cantM>0)
            {
                this.promedioM=(sumM/cantM);
                System.out.println("Promedio de Edades MUJERES = " + promedioM);
            }
            if(cantH>0)
            {
                this.promedioH = (sumH/cantH);
                System.out.println("Promedio de Edades HOMBRES = " + promedioH);
            }
            this.promedioTotal = (sumaTotal/numberOfPerson());
            System.out.println("Promedio de Edades TOTALES = " + promedioTotal);
        }
        else{
            System.out.println("Agregue Personas Al Canton");
        }
    }
    public void CalcularPorcentaje()
    {
        if( numberOfPerson() > 0)
        {
            int cantTrabaja=0;
            for(Persona p : persona)
            {
                if(p.getTrabaja() == true && (p.getEdad() >= 20 && p.getEdad() <= 60) )
                {
                    cantTrabaja++;
                }
            }
            printList();
            System.out.println("---------------------------------------------");
            porcentajePersona = ((100*cantTrabaja)/numberOfPerson());
            System.out.println("Porcentajes de Personas que Trabajan entre(20 y 60 años) = " + porcentajePersona + "%");
        }
        else {
            System.out.println("Agregue Personas Al Canton");
        }
        
    }
  
    
}
