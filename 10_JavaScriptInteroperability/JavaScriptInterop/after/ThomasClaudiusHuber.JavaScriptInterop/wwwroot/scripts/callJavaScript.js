
var blazorJsInterop = blazorJsInterop || {}

blazorJsInterop.showMessage = (message) => { alert(message); };

blazorJsInterop.showPrompt = (message, defaultValue) => { return prompt(message, defaultValue) };

blazorJsInterop.passObject = (obj) => { console.table(obj) };