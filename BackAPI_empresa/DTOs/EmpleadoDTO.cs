namespace BackAPI_empresa.DTOs
{
    public class EmpleadoDTO
    {
        public int IdEmpleado { get; set; }

        public string? NombreEmp { get; set; }

        public string? Apellido { get; set; }

        public int? IdDepartamento { get; set; }
        public string? NombreDepartamento { get; set; }

        public int? Sueldo { get; set; }

        public string? FechaContrato { get; set; }
    }
}
