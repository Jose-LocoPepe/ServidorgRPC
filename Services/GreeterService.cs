using Grpc.Core;
using ServidorgRPC;

namespace ServidorgRPC.Services;

public class GreeterService : Greeter.GreeterBase
{
    // Agregar Cliente by Nico
    public override Task<AgregarReply> AgregarCliente(AgregarRequest request, ServerCallContext context)
    {
         // Aquí se puede agregar la lógica para agregar el cliente a la base de datos
         return Task.FromResult(new AgregarReply
         {
             Message = "Cliente added successfully!"
         });
     }
}
