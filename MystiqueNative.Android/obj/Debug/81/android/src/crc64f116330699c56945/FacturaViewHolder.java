package crc64f116330699c56945;


public class FacturaViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MystiqueNative.Droid.FacturaViewHolder, Fresco", FacturaViewHolder.class, __md_methods);
	}


	public FacturaViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == FacturaViewHolder.class) {
			mono.android.TypeManager.Activate ("MystiqueNative.Droid.FacturaViewHolder, Fresco", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}

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