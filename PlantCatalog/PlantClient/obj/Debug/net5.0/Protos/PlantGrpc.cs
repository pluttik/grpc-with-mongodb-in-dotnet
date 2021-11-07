// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/plant.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PlantCatalog {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class PlantCatalog
  {
    static readonly string __ServiceName = "plant.PlantCatalog";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PlantCatalog.CreatePlantRequest> __Marshaller_plant_CreatePlantRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PlantCatalog.CreatePlantRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PlantCatalog.CreatePlantReply> __Marshaller_plant_CreatePlantReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PlantCatalog.CreatePlantReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PlantCatalog.ReadPlantRequest> __Marshaller_plant_ReadPlantRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PlantCatalog.ReadPlantRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PlantCatalog.ReadPlantReply> __Marshaller_plant_ReadPlantReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PlantCatalog.ReadPlantReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PlantCatalog.UpdatePlantRequest> __Marshaller_plant_UpdatePlantRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PlantCatalog.UpdatePlantRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PlantCatalog.UpdatePlantReply> __Marshaller_plant_UpdatePlantReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PlantCatalog.UpdatePlantReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PlantCatalog.DeletePlantRequest> __Marshaller_plant_DeletePlantRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PlantCatalog.DeletePlantRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PlantCatalog.DeletePlantReply> __Marshaller_plant_DeletePlantReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PlantCatalog.DeletePlantReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PlantCatalog.ListPlantRequest> __Marshaller_plant_ListPlantRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PlantCatalog.ListPlantRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PlantCatalog.ListPlantReply> __Marshaller_plant_ListPlantReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PlantCatalog.ListPlantReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PlantCatalog.CreatePlantRequest, global::PlantCatalog.CreatePlantReply> __Method_CreatePlant = new grpc::Method<global::PlantCatalog.CreatePlantRequest, global::PlantCatalog.CreatePlantReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreatePlant",
        __Marshaller_plant_CreatePlantRequest,
        __Marshaller_plant_CreatePlantReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PlantCatalog.ReadPlantRequest, global::PlantCatalog.ReadPlantReply> __Method_ReadPlant = new grpc::Method<global::PlantCatalog.ReadPlantRequest, global::PlantCatalog.ReadPlantReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadPlant",
        __Marshaller_plant_ReadPlantRequest,
        __Marshaller_plant_ReadPlantReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PlantCatalog.UpdatePlantRequest, global::PlantCatalog.UpdatePlantReply> __Method_UpdatePlant = new grpc::Method<global::PlantCatalog.UpdatePlantRequest, global::PlantCatalog.UpdatePlantReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePlant",
        __Marshaller_plant_UpdatePlantRequest,
        __Marshaller_plant_UpdatePlantReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PlantCatalog.DeletePlantRequest, global::PlantCatalog.DeletePlantReply> __Method_DeletePlant = new grpc::Method<global::PlantCatalog.DeletePlantRequest, global::PlantCatalog.DeletePlantReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePlant",
        __Marshaller_plant_DeletePlantRequest,
        __Marshaller_plant_DeletePlantReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PlantCatalog.ListPlantRequest, global::PlantCatalog.ListPlantReply> __Method_ListPlant = new grpc::Method<global::PlantCatalog.ListPlantRequest, global::PlantCatalog.ListPlantReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListPlant",
        __Marshaller_plant_ListPlantRequest,
        __Marshaller_plant_ListPlantReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PlantCatalog.PlantReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PlantCatalog</summary>
    [grpc::BindServiceMethod(typeof(PlantCatalog), "BindService")]
    public abstract partial class PlantCatalogBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PlantCatalog.CreatePlantReply> CreatePlant(global::PlantCatalog.CreatePlantRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PlantCatalog.ReadPlantReply> ReadPlant(global::PlantCatalog.ReadPlantRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PlantCatalog.UpdatePlantReply> UpdatePlant(global::PlantCatalog.UpdatePlantRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PlantCatalog.DeletePlantReply> DeletePlant(global::PlantCatalog.DeletePlantRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ListPlant(global::PlantCatalog.ListPlantRequest request, grpc::IServerStreamWriter<global::PlantCatalog.ListPlantReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PlantCatalog</summary>
    public partial class PlantCatalogClient : grpc::ClientBase<PlantCatalogClient>
    {
      /// <summary>Creates a new client for PlantCatalog</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PlantCatalogClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PlantCatalog that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PlantCatalogClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PlantCatalogClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PlantCatalogClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PlantCatalog.CreatePlantReply CreatePlant(global::PlantCatalog.CreatePlantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreatePlant(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PlantCatalog.CreatePlantReply CreatePlant(global::PlantCatalog.CreatePlantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreatePlant, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PlantCatalog.CreatePlantReply> CreatePlantAsync(global::PlantCatalog.CreatePlantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreatePlantAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PlantCatalog.CreatePlantReply> CreatePlantAsync(global::PlantCatalog.CreatePlantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreatePlant, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PlantCatalog.ReadPlantReply ReadPlant(global::PlantCatalog.ReadPlantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadPlant(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PlantCatalog.ReadPlantReply ReadPlant(global::PlantCatalog.ReadPlantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadPlant, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PlantCatalog.ReadPlantReply> ReadPlantAsync(global::PlantCatalog.ReadPlantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadPlantAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PlantCatalog.ReadPlantReply> ReadPlantAsync(global::PlantCatalog.ReadPlantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadPlant, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PlantCatalog.UpdatePlantReply UpdatePlant(global::PlantCatalog.UpdatePlantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePlant(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PlantCatalog.UpdatePlantReply UpdatePlant(global::PlantCatalog.UpdatePlantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdatePlant, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PlantCatalog.UpdatePlantReply> UpdatePlantAsync(global::PlantCatalog.UpdatePlantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePlantAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PlantCatalog.UpdatePlantReply> UpdatePlantAsync(global::PlantCatalog.UpdatePlantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdatePlant, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PlantCatalog.DeletePlantReply DeletePlant(global::PlantCatalog.DeletePlantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePlant(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PlantCatalog.DeletePlantReply DeletePlant(global::PlantCatalog.DeletePlantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeletePlant, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PlantCatalog.DeletePlantReply> DeletePlantAsync(global::PlantCatalog.DeletePlantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePlantAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PlantCatalog.DeletePlantReply> DeletePlantAsync(global::PlantCatalog.DeletePlantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeletePlant, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::PlantCatalog.ListPlantReply> ListPlant(global::PlantCatalog.ListPlantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPlant(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::PlantCatalog.ListPlantReply> ListPlant(global::PlantCatalog.ListPlantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ListPlant, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PlantCatalogClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PlantCatalogClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PlantCatalogBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreatePlant, serviceImpl.CreatePlant)
          .AddMethod(__Method_ReadPlant, serviceImpl.ReadPlant)
          .AddMethod(__Method_UpdatePlant, serviceImpl.UpdatePlant)
          .AddMethod(__Method_DeletePlant, serviceImpl.DeletePlant)
          .AddMethod(__Method_ListPlant, serviceImpl.ListPlant).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PlantCatalogBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreatePlant, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PlantCatalog.CreatePlantRequest, global::PlantCatalog.CreatePlantReply>(serviceImpl.CreatePlant));
      serviceBinder.AddMethod(__Method_ReadPlant, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PlantCatalog.ReadPlantRequest, global::PlantCatalog.ReadPlantReply>(serviceImpl.ReadPlant));
      serviceBinder.AddMethod(__Method_UpdatePlant, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PlantCatalog.UpdatePlantRequest, global::PlantCatalog.UpdatePlantReply>(serviceImpl.UpdatePlant));
      serviceBinder.AddMethod(__Method_DeletePlant, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PlantCatalog.DeletePlantRequest, global::PlantCatalog.DeletePlantReply>(serviceImpl.DeletePlant));
      serviceBinder.AddMethod(__Method_ListPlant, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::PlantCatalog.ListPlantRequest, global::PlantCatalog.ListPlantReply>(serviceImpl.ListPlant));
    }

  }
}
#endregion