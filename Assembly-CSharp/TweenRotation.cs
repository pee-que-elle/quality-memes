using System;
using UnityEngine;

// Token: 0x020000DE RID: 222
[AddComponentMenu("NGUI/Tween/Tween Rotation")]
public class TweenRotation : UITweener
{
	// Token: 0x170000DD RID: 221
	// (get) Token: 0x06001A81 RID: 6785 RVA: 0x0000E17D File Offset: 0x0000C37D
	public Transform cachedTransform
	{
		get
		{
			if (this.mTrans == null)
			{
				this.mTrans = base.transform;
			}
			return this.mTrans;
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0000E19F File Offset: 0x0000C39F
	// (set) Token: 0x06001A83 RID: 6787 RVA: 0x0000E1A7 File Offset: 0x0000C3A7
	[Obsolete("Use 'value' instead")]
	public Quaternion rotation
	{
		get
		{
			return this.value;
		}
		set
		{
			this.value = value;
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
	// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0000E1BD File Offset: 0x0000C3BD
	public Quaternion value
	{
		get
		{
			return this.cachedTransform.localRotation;
		}
		set
		{
			this.cachedTransform.localRotation = value;
		}
	}

	// Token: 0x06001A86 RID: 6790 RVA: 0x000B0C6C File Offset: 0x000AEE6C
	protected override void OnUpdate(float factor, bool isFinished)
	{
		this.value = ((!this.quaternionLerp) ? Quaternion.Euler(new Vector3(Mathf.Lerp(this.from.x, this.to.x, factor), Mathf.Lerp(this.from.y, this.to.y, factor), Mathf.Lerp(this.from.z, this.to.z, factor))) : Quaternion.Slerp(Quaternion.Euler(this.from), Quaternion.Euler(this.to), factor));
	}

	// Token: 0x06001A87 RID: 6791 RVA: 0x000B0D04 File Offset: 0x000AEF04
	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		TweenRotation tweenRotation = UITweener.Begin<TweenRotation>(go, duration, 0f);
		tweenRotation.from = tweenRotation.value.eulerAngles;
		tweenRotation.to = rot.eulerAngles;
		if (duration <= 0f)
		{
			tweenRotation.Sample(1f, true);
			tweenRotation.enabled = false;
		}
		return tweenRotation;
	}

	// Token: 0x06001A88 RID: 6792 RVA: 0x000B0D5C File Offset: 0x000AEF5C
	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		this.from = this.value.eulerAngles;
	}

	// Token: 0x06001A89 RID: 6793 RVA: 0x000B0D80 File Offset: 0x000AEF80
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		this.to = this.value.eulerAngles;
	}

	// Token: 0x06001A8A RID: 6794 RVA: 0x0000E1CB File Offset: 0x0000C3CB
	[ContextMenu("Assume value of 'From'")]
	private void SetCurrentValueToStart()
	{
		this.value = Quaternion.Euler(this.from);
	}

	// Token: 0x06001A8B RID: 6795 RVA: 0x0000E1DE File Offset: 0x0000C3DE
	[ContextMenu("Assume value of 'To'")]
	private void SetCurrentValueToEnd()
	{
		this.value = Quaternion.Euler(this.to);
	}

	// Token: 0x04000545 RID: 1349
	public Vector3 from;

	// Token: 0x04000546 RID: 1350
	public Vector3 to;

	// Token: 0x04000547 RID: 1351
	public bool quaternionLerp;

	// Token: 0x04000548 RID: 1352
	private Transform mTrans;
}
