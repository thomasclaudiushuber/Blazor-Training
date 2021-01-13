
var blazorJsInterop = blazorJsInterop || {}

// Call static .NET method
blazorJsInterop.callStaticDotnetMethod = () => {
  var promise = DotNet.invokeMethodAsync("ThomasClaudiusHuber.JavaScriptInterop", "GetGuidString");
  promise.then((result) => alert('received Guid: ' + result));
}

// Call .NET instance method
blazorJsInterop.registerSizeChangedHandler  = (dotNetObjectRef) => {

  var resizeHandler = () => {
    dotNetObjectRef.invokeMethodAsync("SetWindowSize",
      {
        width: window.innerWidth,
        height: window.innerHeight
      });
  };

  // Set up initial values
  resizeHandler();

  // Register event handler
  window.addEventListener("resize", resizeHandler);
}