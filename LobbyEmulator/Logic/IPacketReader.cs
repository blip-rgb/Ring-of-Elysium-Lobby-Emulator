using System.Collections.Generic;

namespace LobbyEmulator.Logic
{
  public interface IPacketReader
  {
    int Port { get; }
    List<byte[]> HandlePacket(byte[] pack);
  }
}
