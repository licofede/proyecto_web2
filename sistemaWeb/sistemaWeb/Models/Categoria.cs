using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaWeb.Models
{
    public class Categoria
    {
        //[Key] //cuando sea llave primaria y no tenga la esctructura nombreTabla + ID
       // [Required] //para que sea un campo obligatorio y va una linea antes del campo oblogatorio
        public int CategoriaID { get; set; }
        [Required(ErrorMessage ="Campo requerido")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="El nombre debe tener de 3 a 50 caracteres")]
        public String Nombre { get; set; }
        [StringLength(256,ErrorMessage ="La descripción no debe exceder los 256 caracteres")]
        [Display(Name ="Descripción")]
        public String Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
