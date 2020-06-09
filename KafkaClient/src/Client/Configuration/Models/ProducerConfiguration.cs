using System;

namespace KafkaClient.src.Client.Configuration.Models
{
    public class ProducerConfiguration
    {
        /// <summary>
        /// Controls how many partition replicas must receive the record.
        /// </summary>
        public int Acks { get; set; }

        /// <summary>
        /// The amount of memory used by the producer to buffer messages.
        /// </summary>
        public int BufferMemory { get; set; }

        /// <summary>
        /// Specifies the client id which will be used by brokers for telemetry.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Amount of time in milliseconds the procuder will wait for
        /// new messages before sending the current batch.
        /// </summary>
        public int LingerMs { get; set; }

        /// <summary>
        /// The maximum amount of time a producer will block when sending
        /// messages or requesting metadata from the server.
        /// </summary>
        public int MaxBlockMs { get; set; }

        /// <summary>
        /// Number of messages a producer will send without receiving a
        /// response.
        /// </summary>
        public int MaxRequestsPerConnection { get; set; }

        /// <summary>
        /// Maximum request size the producer can send to the server. This
        /// caps the largest message that can be sent, as well as the number
        /// of messages that can be sent in a producer request.
        /// </summary>
        public int MaxRequestSize { get; set; }

        /// <summary>
        /// Amount of time in milliseconds the producer will wait for a
        /// server metadata response.
        /// </summary>
        public int MetadataTimeoutMs { get; set; }

        /// <summary>
        /// Size of the TCP send buffer used by a socket. If this is set to -1,
        /// the default OS buffer size is used.
        /// </summary>
        public int ReceiveBufferBytes { get; set; }

        /// <summary>
        /// Amount of time in milliseconds the producer will wait for a server
        /// response after sending messages.
        /// </summary>
        public int RequestTimeoutMs { get; set; }

        /// <summary>
        /// Number of times a producer will retry sending a message.
        /// </summary>
        public int Retries { get; set; }

        /// <summary>
        /// Size of the TCP receive buffer used by a socket. If this is set to
        /// -1, the default OS buffer size is used.
        /// </summary>
        public int SendBufferBytes { get; set; }

        /// <summary>
        /// Amount of time in milliseconds the broker will wait for in-sync
        /// replicas to acknowledge incoming messages to satisfy the acks
        /// parameter.
        /// </summary>
        public int TimeoutMs { get; set; }
    }
}
