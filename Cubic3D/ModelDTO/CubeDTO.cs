namespace Cube3D.API.ModelDTO
{
    public class CubeDTO
    {
        public CubeDTO(string dimensiones, string coordenadas)
        {
            this.Dimensiones = dimensiones;
            this.Coordenadas = coordenadas;
        }
        public string Dimensiones { get; }
        public string Coordenadas { get; }

    }
}
