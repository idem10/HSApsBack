using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsParticipantesConversacion
{
    public long ParticipanteId { get; set; }

    public long? ConversacionId { get; set; }

    public long? UsuarioId { get; set; }
}
