
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Cat.Network {
	public partial class NetworkEntity {


		protected void Multicast(Action Multicast ) 
        {

		    if(Multicast.Target != this)
            {
                throw new Exception("Multicast Invoked on incorrect object!");
            }

            using (MemoryStream stream = new MemoryStream(256))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
					writer.Write((byte)RequestType.Multicast);
					writer.Write(NetworkID.ToByteArray());
					Serializer.WriteMulticastID(writer, Multicast.Method);
					

					Serializer.WriteOutgoingRPCInvocation(stream.ToArray());
				}
			}
        }


		protected void Multicast<T1>(Action<T1> Multicast, T1 _1) where T1 : IEquatable<T1>
        {

		    if(Multicast.Target != this)
            {
                throw new Exception("Multicast Invoked on incorrect object!");
            }

            using (MemoryStream stream = new MemoryStream(256))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
					writer.Write((byte)RequestType.Multicast);
					writer.Write(NetworkID.ToByteArray());
					Serializer.WriteMulticastID(writer, Multicast.Method);
					
					Serializer.SerializationContext.GetSerializationFunction<T1>()(writer, _1);

					Serializer.WriteOutgoingRPCInvocation(stream.ToArray());
				}
			}
        }


		protected void Multicast<T1, T2>(Action<T1, T2> Multicast, T1 _1, T2 _2) where T1 : IEquatable<T1> where T2 : IEquatable<T2>
        {

		    if(Multicast.Target != this)
            {
                throw new Exception("Multicast Invoked on incorrect object!");
            }

            using (MemoryStream stream = new MemoryStream(256))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
					writer.Write((byte)RequestType.Multicast);
					writer.Write(NetworkID.ToByteArray());
					Serializer.WriteMulticastID(writer, Multicast.Method);
					
					Serializer.SerializationContext.GetSerializationFunction<T1>()(writer, _1);
					Serializer.SerializationContext.GetSerializationFunction<T2>()(writer, _2);

					Serializer.WriteOutgoingRPCInvocation(stream.ToArray());
				}
			}
        }


		protected void Multicast<T1, T2, T3>(Action<T1, T2, T3> Multicast, T1 _1, T2 _2, T3 _3) where T1 : IEquatable<T1> where T2 : IEquatable<T2> where T3 : IEquatable<T3>
        {

		    if(Multicast.Target != this)
            {
                throw new Exception("Multicast Invoked on incorrect object!");
            }

            using (MemoryStream stream = new MemoryStream(256))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
					writer.Write((byte)RequestType.Multicast);
					writer.Write(NetworkID.ToByteArray());
					Serializer.WriteMulticastID(writer, Multicast.Method);
					
					Serializer.SerializationContext.GetSerializationFunction<T1>()(writer, _1);
					Serializer.SerializationContext.GetSerializationFunction<T2>()(writer, _2);
					Serializer.SerializationContext.GetSerializationFunction<T3>()(writer, _3);

					Serializer.WriteOutgoingRPCInvocation(stream.ToArray());
				}
			}
        }


		protected void Multicast<T1, T2, T3, T4>(Action<T1, T2, T3, T4> Multicast, T1 _1, T2 _2, T3 _3, T4 _4) where T1 : IEquatable<T1> where T2 : IEquatable<T2> where T3 : IEquatable<T3> where T4 : IEquatable<T4>
        {

		    if(Multicast.Target != this)
            {
                throw new Exception("Multicast Invoked on incorrect object!");
            }

            using (MemoryStream stream = new MemoryStream(256))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
					writer.Write((byte)RequestType.Multicast);
					writer.Write(NetworkID.ToByteArray());
					Serializer.WriteMulticastID(writer, Multicast.Method);
					
					Serializer.SerializationContext.GetSerializationFunction<T1>()(writer, _1);
					Serializer.SerializationContext.GetSerializationFunction<T2>()(writer, _2);
					Serializer.SerializationContext.GetSerializationFunction<T3>()(writer, _3);
					Serializer.SerializationContext.GetSerializationFunction<T4>()(writer, _4);

					Serializer.WriteOutgoingRPCInvocation(stream.ToArray());
				}
			}
        }


		protected void Multicast<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> Multicast, T1 _1, T2 _2, T3 _3, T4 _4, T5 _5) where T1 : IEquatable<T1> where T2 : IEquatable<T2> where T3 : IEquatable<T3> where T4 : IEquatable<T4> where T5 : IEquatable<T5>
        {

		    if(Multicast.Target != this)
            {
                throw new Exception("Multicast Invoked on incorrect object!");
            }

            using (MemoryStream stream = new MemoryStream(256))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
					writer.Write((byte)RequestType.Multicast);
					writer.Write(NetworkID.ToByteArray());
					Serializer.WriteMulticastID(writer, Multicast.Method);
					
					Serializer.SerializationContext.GetSerializationFunction<T1>()(writer, _1);
					Serializer.SerializationContext.GetSerializationFunction<T2>()(writer, _2);
					Serializer.SerializationContext.GetSerializationFunction<T3>()(writer, _3);
					Serializer.SerializationContext.GetSerializationFunction<T4>()(writer, _4);
					Serializer.SerializationContext.GetSerializationFunction<T5>()(writer, _5);

					Serializer.WriteOutgoingRPCInvocation(stream.ToArray());
				}
			}
        }


		protected void Multicast<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> Multicast, T1 _1, T2 _2, T3 _3, T4 _4, T5 _5, T6 _6) where T1 : IEquatable<T1> where T2 : IEquatable<T2> where T3 : IEquatable<T3> where T4 : IEquatable<T4> where T5 : IEquatable<T5> where T6 : IEquatable<T6>
        {

		    if(Multicast.Target != this)
            {
                throw new Exception("Multicast Invoked on incorrect object!");
            }

            using (MemoryStream stream = new MemoryStream(256))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
					writer.Write((byte)RequestType.Multicast);
					writer.Write(NetworkID.ToByteArray());
					Serializer.WriteMulticastID(writer, Multicast.Method);
					
					Serializer.SerializationContext.GetSerializationFunction<T1>()(writer, _1);
					Serializer.SerializationContext.GetSerializationFunction<T2>()(writer, _2);
					Serializer.SerializationContext.GetSerializationFunction<T3>()(writer, _3);
					Serializer.SerializationContext.GetSerializationFunction<T4>()(writer, _4);
					Serializer.SerializationContext.GetSerializationFunction<T5>()(writer, _5);
					Serializer.SerializationContext.GetSerializationFunction<T6>()(writer, _6);

					Serializer.WriteOutgoingRPCInvocation(stream.ToArray());
				}
			}
        }


		protected void Multicast<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> Multicast, T1 _1, T2 _2, T3 _3, T4 _4, T5 _5, T6 _6, T7 _7) where T1 : IEquatable<T1> where T2 : IEquatable<T2> where T3 : IEquatable<T3> where T4 : IEquatable<T4> where T5 : IEquatable<T5> where T6 : IEquatable<T6> where T7 : IEquatable<T7>
        {

		    if(Multicast.Target != this)
            {
                throw new Exception("Multicast Invoked on incorrect object!");
            }

            using (MemoryStream stream = new MemoryStream(256))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
					writer.Write((byte)RequestType.Multicast);
					writer.Write(NetworkID.ToByteArray());
					Serializer.WriteMulticastID(writer, Multicast.Method);
					
					Serializer.SerializationContext.GetSerializationFunction<T1>()(writer, _1);
					Serializer.SerializationContext.GetSerializationFunction<T2>()(writer, _2);
					Serializer.SerializationContext.GetSerializationFunction<T3>()(writer, _3);
					Serializer.SerializationContext.GetSerializationFunction<T4>()(writer, _4);
					Serializer.SerializationContext.GetSerializationFunction<T5>()(writer, _5);
					Serializer.SerializationContext.GetSerializationFunction<T6>()(writer, _6);
					Serializer.SerializationContext.GetSerializationFunction<T7>()(writer, _7);

					Serializer.WriteOutgoingRPCInvocation(stream.ToArray());
				}
			}
        }


		protected void Multicast<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> Multicast, T1 _1, T2 _2, T3 _3, T4 _4, T5 _5, T6 _6, T7 _7, T8 _8) where T1 : IEquatable<T1> where T2 : IEquatable<T2> where T3 : IEquatable<T3> where T4 : IEquatable<T4> where T5 : IEquatable<T5> where T6 : IEquatable<T6> where T7 : IEquatable<T7> where T8 : IEquatable<T8>
        {

		    if(Multicast.Target != this)
            {
                throw new Exception("Multicast Invoked on incorrect object!");
            }

            using (MemoryStream stream = new MemoryStream(256))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
					writer.Write((byte)RequestType.Multicast);
					writer.Write(NetworkID.ToByteArray());
					Serializer.WriteMulticastID(writer, Multicast.Method);
					
					Serializer.SerializationContext.GetSerializationFunction<T1>()(writer, _1);
					Serializer.SerializationContext.GetSerializationFunction<T2>()(writer, _2);
					Serializer.SerializationContext.GetSerializationFunction<T3>()(writer, _3);
					Serializer.SerializationContext.GetSerializationFunction<T4>()(writer, _4);
					Serializer.SerializationContext.GetSerializationFunction<T5>()(writer, _5);
					Serializer.SerializationContext.GetSerializationFunction<T6>()(writer, _6);
					Serializer.SerializationContext.GetSerializationFunction<T7>()(writer, _7);
					Serializer.SerializationContext.GetSerializationFunction<T8>()(writer, _8);

					Serializer.WriteOutgoingRPCInvocation(stream.ToArray());
				}
			}
        }


	}
}


