
/**
 * Write a description of class Persona here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Persona
{
    // instance variables - replace the example below with your own
    private String nombre;
    private boolean sexo;
    private int ID;
    private int edad;
    private boolean trabaja;

    /**
     * Constructor for objects of class Persona
     */
    public Persona(int ID,String nombre,boolean sexo,int edad,boolean trabaja)
    {
        // initialise instance variables
        this.nombre = nombre;
        this.sexo = sexo;
        this.edad = edad;
        this.ID = ID;
        this.trabaja = trabaja;
    }
    public String getNombre()
    {   
        return nombre;
    }
    public boolean getSexo()
    {
        return sexo;
    }
    public int getEdad()
    {  
        return edad;
    }
    public boolean getTrabaja()
    {
        return trabaja;
    }
    public void cambiarNombre(String newName)
    {
        nombre = newName;
    }
}
