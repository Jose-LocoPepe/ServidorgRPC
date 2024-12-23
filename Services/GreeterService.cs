using Grpc.Core;
using ServidorgRPC;

namespace ServidorgRPC.Services;

public class GreeterService : Greeter.GreeterBase
{
    // Agregar Cliente by Nico
    public override Task<AgregarReply> AgregarCliente(AgregarRequest request, ServerCallContext context)
    {
        ReservasContext reservaContext = new();
        reservaContext.Clientes.Add(new Cliente
        {
            Rut = int.Parse(request.Rut),
            Nombre = request.Nombre,
            Apellido = request.Apellido
        });
        reservaContext.SaveChanges();

        return Task.FromResult(new AgregarReply
        {
            Message = "Cliente agregado correctamente!"
        });
    }
}
