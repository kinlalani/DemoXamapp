package crc64bd671c3f4c9a1d40;


public class MainActivity_FailureListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.tasks.OnFailureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailure:(Ljava/lang/Exception;)V:GetOnFailure_Ljava_lang_Exception_Handler:Android.Gms.Tasks.IOnFailureListenerInvoker, Xamarin.GooglePlayServices.Tasks\n" +
			"";
		mono.android.Runtime.register ("demo1.Droid.MainActivity+FailureListener, demo1.Android", MainActivity_FailureListener.class, __md_methods);
	}


	public MainActivity_FailureListener ()
	{
		super ();
		if (getClass () == MainActivity_FailureListener.class) {
			mono.android.TypeManager.Activate ("demo1.Droid.MainActivity+FailureListener, demo1.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public void onFailure (java.lang.Exception p0)
	{
		n_onFailure (p0);
	}

	private native void n_onFailure (java.lang.Exception p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
