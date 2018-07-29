using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000E3 RID: 227
public abstract class UITweener : MonoBehaviour
{
	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06001B72 RID: 7026 RVA: 0x000B41E0 File Offset: 0x000B23E0
	public float amountPerDelta
	{
		get
		{
			if (this.duration == 0f)
			{
				return 1000f;
			}
			if (this.mDuration != this.duration)
			{
				this.mDuration = this.duration;
				this.mAmountPerDelta = Mathf.Abs(1f / this.duration) * Mathf.Sign(this.mAmountPerDelta);
			}
			return this.mAmountPerDelta;
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06001B73 RID: 7027 RVA: 0x0000E856 File Offset: 0x0000CA56
	// (set) Token: 0x06001B74 RID: 7028 RVA: 0x0000E85E File Offset: 0x0000CA5E
	public float tweenFactor
	{
		get
		{
			return this.mFactor;
		}
		set
		{
			this.mFactor = Mathf.Clamp01(value);
		}
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x06001B75 RID: 7029 RVA: 0x0000E86C File Offset: 0x0000CA6C
	public QMDFDJEIEMO direction
	{
		get
		{
			return (this.amountPerDelta >= 0f) ? QMDFDJEIEMO.Forward : QMDFDJEIEMO.Reverse;
		}
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x0000E87F File Offset: 0x0000CA7F
	private void Reset()
	{
		if (!this.mStarted)
		{
			this.SetStartToCurrentValue();
			this.SetEndToCurrentValue();
		}
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x0000E895 File Offset: 0x0000CA95
	protected virtual void Start()
	{
		this.DoUpdate();
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x0000E89D File Offset: 0x0000CA9D
	protected void Update()
	{
		if (!this.useFixedUpdate)
		{
			this.DoUpdate();
		}
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x0000E8AD File Offset: 0x0000CAAD
	protected void FixedUpdate()
	{
		if (this.useFixedUpdate)
		{
			this.DoUpdate();
		}
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x000B4244 File Offset: 0x000B2444
	protected void DoUpdate()
	{
		float num = (!this.ignoreTimeScale || this.useFixedUpdate) ? Time.deltaTime : JMIOBJFFGBN.GPFIDEJEMEG;
		float num2 = (!this.ignoreTimeScale || this.useFixedUpdate) ? Time.time : JMIOBJFFGBN.MOGLGJGFNDM;
		if (!this.mStarted)
		{
			num = 0f;
			this.mStarted = true;
			this.mStartTime = num2 + this.delay;
		}
		if (num2 < this.mStartTime)
		{
			return;
		}
		this.mFactor += ((this.duration != 0f) ? (this.amountPerDelta * num) : 1f);
		if (this.style == UITweener.DGIBNCIOKJJ.Loop)
		{
			if (this.mFactor > 1f)
			{
				this.mFactor -= Mathf.Floor(this.mFactor);
			}
		}
		else if (this.style == UITweener.DGIBNCIOKJJ.PingPong)
		{
			if (this.mFactor > 1f)
			{
				this.mFactor = 1f - (this.mFactor - Mathf.Floor(this.mFactor));
				this.mAmountPerDelta = -this.mAmountPerDelta;
			}
			else if (this.mFactor < 0f)
			{
				this.mFactor = -this.mFactor;
				this.mFactor -= Mathf.Floor(this.mFactor);
				this.mAmountPerDelta = -this.mAmountPerDelta;
			}
		}
		if (this.style == UITweener.DGIBNCIOKJJ.Once && (this.duration == 0f || this.mFactor > 1f || this.mFactor < 0f))
		{
			this.mFactor = Mathf.Clamp01(this.mFactor);
			this.Sample(this.mFactor, true);
			base.enabled = false;
			if (UITweener.current != this)
			{
				UITweener uitweener = UITweener.current;
				UITweener.current = this;
				if (this.onFinished != null)
				{
					this.mTemp = this.onFinished;
					this.onFinished = new List<EventDelegate>();
					EventDelegate.CPGBBDIDOID(this.mTemp);
					for (int i = 0; i < this.mTemp.Count; i++)
					{
						EventDelegate eventDelegate = this.mTemp[i];
						if (eventDelegate != null && !eventDelegate.oneShot)
						{
							EventDelegate.LHQECHHMOGD(this.onFinished, eventDelegate, eventDelegate.oneShot);
						}
					}
					this.mTemp = null;
				}
				if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
				{
					this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
				}
				UITweener.current = uitweener;
			}
		}
		else
		{
			this.Sample(this.mFactor, false);
		}
	}

	// Token: 0x06001B7B RID: 7035 RVA: 0x0000E8BD File Offset: 0x0000CABD
	public void SetOnFinished(EventDelegate.LKPMKQMCHFH del)
	{
		EventDelegate.PJMIKDIEGMB(this.onFinished, del);
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x0000E8CC File Offset: 0x0000CACC
	public void SetOnFinished(EventDelegate del)
	{
		EventDelegate.PJMIKDIEGMB(this.onFinished, del);
	}

	// Token: 0x06001B7D RID: 7037 RVA: 0x0000E8DA File Offset: 0x0000CADA
	public void AddOnFinished(EventDelegate.LKPMKQMCHFH del)
	{
		EventDelegate.LHQECHHMOGD(this.onFinished, del);
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x0000E8E9 File Offset: 0x0000CAE9
	public void AddOnFinished(EventDelegate del)
	{
		EventDelegate.LHQECHHMOGD(this.onFinished, del);
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x0000E8F7 File Offset: 0x0000CAF7
	public void RemoveOnFinished(EventDelegate del)
	{
		if (this.onFinished != null)
		{
			this.onFinished.Remove(del);
		}
		if (this.mTemp != null)
		{
			this.mTemp.Remove(del);
		}
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x0000E923 File Offset: 0x0000CB23
	private void OnDisable()
	{
		this.mStarted = false;
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x000B44C8 File Offset: 0x000B26C8
	public void Sample(float factor, bool isFinished)
	{
		float num = Mathf.Clamp01(factor);
		if (this.method == UITweener.JGHNOICEQDB.EaseIn)
		{
			num = 1f - Mathf.Sin(1.57079637f * (1f - num));
			if (this.steeperCurves)
			{
				num *= num;
			}
		}
		else if (this.method == UITweener.JGHNOICEQDB.EaseOut)
		{
			num = Mathf.Sin(1.57079637f * num);
			if (this.steeperCurves)
			{
				num = 1f - num;
				num = 1f - num * num;
			}
		}
		else if (this.method == UITweener.JGHNOICEQDB.EaseInOut)
		{
			num -= Mathf.Sin(num * 6.28318548f) / 6.28318548f;
			if (this.steeperCurves)
			{
				num = num * 2f - 1f;
				float num2 = Mathf.Sign(num);
				num = 1f - Mathf.Abs(num);
				num = 1f - num * num;
				num = num2 * num * 0.5f + 0.5f;
			}
		}
		else if (this.method == UITweener.JGHNOICEQDB.BounceIn)
		{
			num = this.BounceLogic(num);
		}
		else if (this.method == UITweener.JGHNOICEQDB.BounceOut)
		{
			num = 1f - this.BounceLogic(1f - num);
		}
		this.OnUpdate((this.animationCurve == null) ? num : this.animationCurve.Evaluate(num), isFinished);
	}

	// Token: 0x06001B82 RID: 7042 RVA: 0x000B45FC File Offset: 0x000B27FC
	private float BounceLogic(float val)
	{
		if (val < 0.363636f)
		{
			val = 7.5685f * val * val;
		}
		else if (val < 0.727272f)
		{
			val = 7.5625f * (val -= 0.545454f) * val + 0.75f;
		}
		else if (val < 0.90909f)
		{
			val = 7.5625f * (val -= 0.818181f) * val + 0.9375f;
		}
		else
		{
			val = 7.5625f * (val -= 0.9545454f) * val + 0.984375f;
		}
		return val;
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x0000E92C File Offset: 0x0000CB2C
	[Obsolete("Use PlayForward() instead")]
	public void Play()
	{
		this.Play(true);
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x0000E935 File Offset: 0x0000CB35
	public void PlayForward()
	{
		this.mFactor = 0.0001f;
		this.Play(true);
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x0000E949 File Offset: 0x0000CB49
	public void PlayReverse()
	{
		this.Play(false);
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x0000E952 File Offset: 0x0000CB52
	public virtual void Play(bool forward)
	{
		this.mAmountPerDelta = Mathf.Abs(this.amountPerDelta);
		if (!forward)
		{
			this.mAmountPerDelta = -this.mAmountPerDelta;
		}
		if (!base.enabled)
		{
			base.enabled = true;
			this.mStarted = false;
		}
		this.DoUpdate();
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x0000E991 File Offset: 0x0000CB91
	public void ResetToBeginning()
	{
		this.mStarted = false;
		this.mFactor = ((this.amountPerDelta >= 0f) ? 0f : 1f);
		this.Sample(this.mFactor, false);
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x0000E9C6 File Offset: 0x0000CBC6
	public void Toggle()
	{
		if (this.mFactor > 0f)
		{
			this.mAmountPerDelta = -this.amountPerDelta;
		}
		else
		{
			this.mAmountPerDelta = Mathf.Abs(this.amountPerDelta);
		}
		base.enabled = true;
	}

	// Token: 0x06001B89 RID: 7049
	protected abstract void OnUpdate(float factor, bool isFinished);

	// Token: 0x06001B8A RID: 7050 RVA: 0x000B4684 File Offset: 0x000B2884
	public static T Begin<T>(GameObject go, float duration, float delay = 0f) where T : UITweener
	{
		T t = go.GetComponent<T>();
		if (t != null && t.tweenGroup != 0)
		{
			t = (T)((object)null);
			T[] components = go.GetComponents<T>();
			int i = 0;
			int num = components.Length;
			while (i < num)
			{
				t = components[i];
				if (t != null && t.tweenGroup == 0)
				{
					break;
				}
				t = (T)((object)null);
				i++;
			}
		}
		if (t == null)
		{
			t = go.AddComponent<T>();
			if (t == null)
			{
				Debug.LogError(string.Concat(new object[]
				{
					"Unable to add ",
					typeof(T),
					" to ",
					IKBQNBHOJJB.IHLEQHINJKK(go)
				}), go);
				return (T)((object)null);
			}
		}
		t.mStarted = false;
		t.mFactor = 0f;
		t.duration = duration;
		t.mDuration = duration;
		t.delay = delay;
		t.mAmountPerDelta = ((duration <= 0f) ? 1000f : Mathf.Abs(1f / duration));
		t.style = UITweener.DGIBNCIOKJJ.Once;
		t.animationCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f, 0f, 1f),
			new Keyframe(1f, 1f, 1f, 0f)
		});
		t.eventReceiver = null;
		t.callWhenFinished = null;
		t.onFinished.Clear();
		if (t.mTemp != null)
		{
			t.mTemp.Clear();
		}
		t.enabled = true;
		return t;
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void SetStartToCurrentValue()
	{
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void SetEndToCurrentValue()
	{
	}

	// Token: 0x0400055D RID: 1373
	public static UITweener current;

	// Token: 0x0400055E RID: 1374
	[HideInInspector]
	public UITweener.JGHNOICEQDB method;

	// Token: 0x0400055F RID: 1375
	[HideInInspector]
	public UITweener.DGIBNCIOKJJ style;

	// Token: 0x04000560 RID: 1376
	[HideInInspector]
	public AnimationCurve animationCurve = new AnimationCurve(new Keyframe[]
	{
		new Keyframe(0f, 0f, 0f, 1f),
		new Keyframe(1f, 1f, 1f, 0f)
	});

	// Token: 0x04000561 RID: 1377
	[HideInInspector]
	public bool ignoreTimeScale = true;

	// Token: 0x04000562 RID: 1378
	[HideInInspector]
	public float delay;

	// Token: 0x04000563 RID: 1379
	[HideInInspector]
	public float duration = 1f;

	// Token: 0x04000564 RID: 1380
	[HideInInspector]
	public bool steeperCurves;

	// Token: 0x04000565 RID: 1381
	[HideInInspector]
	public int tweenGroup;

	// Token: 0x04000566 RID: 1382
	[Tooltip("By default, Update() will be used for tweening. Setting this to 'true' will make the tween happen in FixedUpdate() insted.")]
	public bool useFixedUpdate;

	// Token: 0x04000567 RID: 1383
	[HideInInspector]
	public List<EventDelegate> onFinished = new List<EventDelegate>();

	// Token: 0x04000568 RID: 1384
	[HideInInspector]
	public GameObject eventReceiver;

	// Token: 0x04000569 RID: 1385
	[HideInInspector]
	public string callWhenFinished;

	// Token: 0x0400056A RID: 1386
	private bool mStarted;

	// Token: 0x0400056B RID: 1387
	private float mStartTime;

	// Token: 0x0400056C RID: 1388
	private float mDuration;

	// Token: 0x0400056D RID: 1389
	private float mAmountPerDelta = 1000f;

	// Token: 0x0400056E RID: 1390
	private float mFactor;

	// Token: 0x0400056F RID: 1391
	private List<EventDelegate> mTemp;

	// Token: 0x020000E4 RID: 228
	public enum JGHNOICEQDB
	{
		// Token: 0x04000571 RID: 1393
		Linear,
		// Token: 0x04000572 RID: 1394
		EaseIn,
		// Token: 0x04000573 RID: 1395
		EaseOut,
		// Token: 0x04000574 RID: 1396
		EaseInOut,
		// Token: 0x04000575 RID: 1397
		BounceIn,
		// Token: 0x04000576 RID: 1398
		BounceOut
	}

	// Token: 0x020000E5 RID: 229
	public enum DGIBNCIOKJJ
	{
		// Token: 0x04000578 RID: 1400
		Once,
		// Token: 0x04000579 RID: 1401
		Loop,
		// Token: 0x0400057A RID: 1402
		PingPong
	}
}
