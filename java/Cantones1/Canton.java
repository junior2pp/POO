
/**
 * Write a description of class Canton here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
import java.util.*;

public class Canton
{
    // instance variables - replace the example below with your own
   
    private ArrayList<String> cantones = new ArrayList<String>();

    /**
     * Constructor for objects of class Canton
     */
    public Canton()
    {
        // initialise instance variables
       
    }

    /**
     * An example of a method - replace this comment with your own
     * 
     * @param  y   a sample parameter for a method
     * @return     the sum of x and y 
     */
    
    public void Create(String Canton){
        cantones.add(Canton);
    }
    public void Update(int id,String NuevoCanton){
        cantones.set(id,NuevoCanton);
        System.out.println("CANTON ACTUALIZADO");
    }
    public void Delete(int id){
        cantones.remove(id);
        System.out.println("CANTON ELIMINADO");
    }
    public void GetAll(){
        System.out.println("ID--NOMBRE");
        System.out.println("-----------");
        Iterator<String> iterador = cantones.iterator();
        int j=0;
        while(iterador.hasNext())
        {
            System.out.println(j+"--"+iterador.next());
            j++;
        }
    }
    public String GetbyID(int id){
          return cantones.get(id);
    }
    public int GetQuantity(){
        return cantones.size();
    }
    public boolean Contains(String Canton){
        return cantones.contains(Canton);
    }
    public void DeleteAll(){
        cantones.clear();
        System.out.println("CANTONES ELIMINADOS");
    }
    
}
