using System;
using System.Collections.Generic;

namespace BackAPI_empresa.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? NombreEmp { get; set; }

    public string? Apellido { get; set; }

    public int? IdDepartamento { get; set; }

    public int? Sueldo { get; set; }

    public DateTime? FechaContrato { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual Departamento? IdDepartamentoNavigation { get; set; }
}
