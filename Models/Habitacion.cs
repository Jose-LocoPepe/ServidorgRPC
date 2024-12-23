using System;
using System.Collections.Generic;

namespace ServidorgRPC;

public partial class Habitacion
{
    public int Id { get; set; }

    public int Numero { get; set; }

    public virtual ICollection<Reserva> Reservas { get; } = new List<Reserva>();
}
