package crc6454f3457678447c99;


public class SfRadialMenu
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_dispatchTouchEvent:(Landroid/view/MotionEvent;)Z:GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onSizeChanged:(IIII)V:GetOnSizeChanged_IIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.SfRadialMenu.Android.SfRadialMenu, Syncfusion.SfRadialMenu.Android", SfRadialMenu.class, __md_methods);
	}


	public SfRadialMenu (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SfRadialMenu.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfRadialMenu.Android.SfRadialMenu, Syncfusion.SfRadialMenu.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public SfRadialMenu (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SfRadialMenu.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfRadialMenu.Android.SfRadialMenu, Syncfusion.SfRadialMenu.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SfRadialMenu (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SfRadialMenu.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfRadialMenu.Android.SfRadialMenu, Syncfusion.SfRadialMenu.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SfRadialMenu (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == SfRadialMenu.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfRadialMenu.Android.SfRadialMenu, Syncfusion.SfRadialMenu.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public boolean dispatchTouchEvent (android.view.MotionEvent p0)
	{
		return n_dispatchTouchEvent (p0);
	}

	private native boolean n_dispatchTouchEvent (android.view.MotionEvent p0);


	public void onSizeChanged (int p0, int p1, int p2, int p3)
	{
		n_onSizeChanged (p0, p1, p2, p3);
	}

	private native void n_onSizeChanged (int p0, int p1, int p2, int p3);

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
