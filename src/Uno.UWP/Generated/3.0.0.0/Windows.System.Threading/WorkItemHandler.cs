#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Threading
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	public delegate void WorkItemHandler(global::Windows.Foundation.IAsyncAction @operation);
	#endif
}
