
namespace Pizzas.Api.Models
{
    public class Pizza
{
    private int _Id;
    private string _Nombre;
    private bool _LibreGLuten;
    private double _Importe;
    private string _Descripcion;
   

    public int Id
    {
        get{return _Id;}
        set{_Id = value;}
    }
    public string Nombre
    {
        get{return _Nombre;}
        set{_Nombre= value;}
    }
    public bool LibreGLuten
    {
        get{return _LibreGLuten;}
        set{_LibreGLuten= value;}
    }
    public double Importe
    {
        get{return _Importe;}
        set{_Importe= value;}
    }
    public string Descripcion
    {
        get{return _Descripcion;}
        set{_Descripcion= value;}
    }
}

}

