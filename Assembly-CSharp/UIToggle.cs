using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000088 RID: 136
[AddComponentMenu("NGUI/Interaction/Toggle")]
[ExecuteInEditMode]
public class UIToggle : GJGCJNOICOM
{
	// Token: 0x17000057 RID: 87
	// (get) Token: 0x060011D9 RID: 4569 RVA: 0x0000A638 File Offset: 0x00008838
	// (set) Token: 0x060011DA RID: 4570 RVA: 0x0000A650 File Offset: 0x00008850
	public bool value
	{
		get
		{
			return (!this.mStarted) ? this.startsActive : this.mIsActive;
		}
		set
		{
			if (!this.mStarted)
			{
				this.startsActive = value;
			}
			else if (this.group == 0 || value || this.optionCanBeNone || !this.mStarted)
			{
				this.Set(value, true);
			}
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x060011DB RID: 4571 RVA: 0x00070898 File Offset: 0x0006EA98
	public bool isColliderEnabled
	{
		get
		{
			Collider component = base.GetComponent<Collider>();
			if (component != null)
			{
				return component.enabled;
			}
			Collider2D component2 = base.GetComponent<Collider2D>();
			return component2 != null && component2.enabled;
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x060011DC RID: 4572 RVA: 0x0000A686 File Offset: 0x00008886
	// (set) Token: 0x060011DD RID: 4573 RVA: 0x0000A68E File Offset: 0x0000888E
	[Obsolete("Use 'value' instead")]
	public bool isChecked
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

	// Token: 0x060011DE RID: 4574 RVA: 0x000869F0 File Offset: 0x00084BF0
	public static UIToggle GetActiveToggle(int group)
	{
		for (int i = 0; i < UIToggle.list.BJGMIBBEGDQ; i++)
		{
			UIToggle uitoggle = UIToggle.list.get_KNPPMKBOGDL(i);
			if (uitoggle != null && uitoggle.group == group && uitoggle.mIsActive)
			{
				return uitoggle;
			}
		}
		return null;
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x0000A697 File Offset: 0x00008897
	private void OnEnable()
	{
		UIToggle.list.LHQECHHMOGD(this);
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x0000A6A4 File Offset: 0x000088A4
	private void OnDisable()
	{
		UIToggle.list.FQDMDDOHCQJ(this);
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00086A3C File Offset: 0x00084C3C
	public void Start()
	{
		if (this.mStarted)
		{
			return;
		}
		if (this.startsChecked)
		{
			this.startsChecked = false;
			this.startsActive = true;
		}
		if (!Application.isPlaying)
		{
			if (this.checkSprite != null && this.activeSprite == null)
			{
				this.activeSprite = this.checkSprite;
				this.checkSprite = null;
			}
			if (this.checkAnimation != null && this.activeAnimation == null)
			{
				this.activeAnimation = this.checkAnimation;
				this.checkAnimation = null;
			}
			if (Application.isPlaying && this.activeSprite != null)
			{
				this.activeSprite.DIIHJCJOKMP = ((!this.invertSpriteState) ? ((!this.startsActive) ? 0f : 1f) : ((!this.startsActive) ? 1f : 0f));
			}
			if (EventDelegate.CPPLNKNPLPI(this.onChange))
			{
				this.eventReceiver = null;
				this.functionName = null;
			}
		}
		else
		{
			this.mIsActive = !this.startsActive;
			this.mStarted = true;
			bool flag = this.instantTween;
			this.instantTween = true;
			this.Set(this.startsActive, true);
			this.instantTween = flag;
		}
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x0000A6B2 File Offset: 0x000088B2
	private void OnClick()
	{
		if (base.enabled && this.isColliderEnabled && EMENMKHBPQE.JQCODFPLPNJ != -2)
		{
			this.value = !this.value;
		}
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00086B78 File Offset: 0x00084D78
	public void Set(bool state, bool notify = true)
	{
		if (this.validator != null && !this.validator(state))
		{
			return;
		}
		if (!this.mStarted)
		{
			this.mIsActive = state;
			this.startsActive = state;
			if (this.activeSprite != null)
			{
				this.activeSprite.DIIHJCJOKMP = ((!this.invertSpriteState) ? ((!state) ? 0f : 1f) : ((!state) ? 1f : 0f));
			}
		}
		else if (this.mIsActive != state)
		{
			if (this.group != 0 && state)
			{
				int i = 0;
				int bjgmibbegdq = UIToggle.list.BJGMIBBEGDQ;
				while (i < bjgmibbegdq)
				{
					UIToggle uitoggle = UIToggle.list.get_KNPPMKBOGDL(i);
					if (uitoggle != this && uitoggle.group == this.group)
					{
						uitoggle.Set(false, true);
					}
					if (UIToggle.list.BJGMIBBEGDQ != bjgmibbegdq)
					{
						bjgmibbegdq = UIToggle.list.BJGMIBBEGDQ;
						i = 0;
					}
					else
					{
						i++;
					}
				}
			}
			this.mIsActive = state;
			if (this.activeSprite != null)
			{
				if (!this.instantTween && IKBQNBHOJJB.PBBDNDMELHQ(this))
				{
					EPIJJNOIKEK.FJCEGFKJLCL(this.activeSprite.gameObject, 0.15f, (!this.invertSpriteState) ? ((!this.mIsActive) ? 0f : 1f) : ((!this.mIsActive) ? 1f : 0f), 0f);
				}
				else
				{
					this.activeSprite.DIIHJCJOKMP = ((!this.invertSpriteState) ? ((!this.mIsActive) ? 0f : 1f) : ((!this.mIsActive) ? 1f : 0f));
				}
			}
			if (notify && UIToggle.current == null)
			{
				UIToggle uitoggle2 = UIToggle.current;
				UIToggle.current = this;
				if (EventDelegate.CPPLNKNPLPI(this.onChange))
				{
					EventDelegate.CPGBBDIDOID(this.onChange);
				}
				else if (this.eventReceiver != null && !string.IsNullOrEmpty(this.functionName))
				{
					this.eventReceiver.SendMessage(this.functionName, this.mIsActive, SendMessageOptions.DontRequireReceiver);
				}
				UIToggle.current = uitoggle2;
			}
			if (this.animator != null)
			{
				QDBCMHDINGL qdbcmhdingl = QDBCMHDINGL.MLOIHHQMFBN(this.animator, null, (!state) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Forward, GKKIEDPNJIF.IgnoreDisabledState, PNDJHKBEPNM.DoNotDisable);
				if (qdbcmhdingl != null && (this.instantTween || !IKBQNBHOJJB.PBBDNDMELHQ(this)))
				{
					qdbcmhdingl.INNQKLOKBFL();
				}
			}
			else if (this.activeAnimation != null)
			{
				QDBCMHDINGL qdbcmhdingl2 = QDBCMHDINGL.MLOIHHQMFBN(this.activeAnimation, null, (!state) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Forward, GKKIEDPNJIF.IgnoreDisabledState, PNDJHKBEPNM.DoNotDisable);
				if (qdbcmhdingl2 != null && (this.instantTween || !IKBQNBHOJJB.PBBDNDMELHQ(this)))
				{
					qdbcmhdingl2.INNQKLOKBFL();
				}
			}
			else if (this.tween != null)
			{
				bool flag = IKBQNBHOJJB.PBBDNDMELHQ(this);
				if (this.tween.tweenGroup != 0)
				{
					UITweener[] componentsInChildren = this.tween.GetComponentsInChildren<UITweener>(true);
					int j = 0;
					int num = componentsInChildren.Length;
					while (j < num)
					{
						UITweener uitweener = componentsInChildren[j];
						if (uitweener.tweenGroup == this.tween.tweenGroup)
						{
							uitweener.Play(state);
							if (this.instantTween || !flag)
							{
								uitweener.tweenFactor = ((!state) ? 0f : 1f);
							}
						}
						j++;
					}
				}
				else
				{
					this.tween.Play(state);
					if (this.instantTween || !flag)
					{
						this.tween.tweenFactor = ((!state) ? 0f : 1f);
					}
				}
			}
		}
	}

	// Token: 0x0400033E RID: 830
	public static MHIDKMCBQEN<UIToggle> list = new MHIDKMCBQEN<UIToggle>();

	// Token: 0x0400033F RID: 831
	public static UIToggle current;

	// Token: 0x04000340 RID: 832
	public int group;

	// Token: 0x04000341 RID: 833
	public ENFMCDNLEQQ activeSprite;

	// Token: 0x04000342 RID: 834
	public bool invertSpriteState;

	// Token: 0x04000343 RID: 835
	public Animation activeAnimation;

	// Token: 0x04000344 RID: 836
	public Animator animator;

	// Token: 0x04000345 RID: 837
	public UITweener tween;

	// Token: 0x04000346 RID: 838
	public bool startsActive;

	// Token: 0x04000347 RID: 839
	public bool instantTween;

	// Token: 0x04000348 RID: 840
	public bool optionCanBeNone;

	// Token: 0x04000349 RID: 841
	public List<EventDelegate> onChange = new List<EventDelegate>();

	// Token: 0x0400034A RID: 842
	public UIToggle.LMDIPLJPLBO validator;

	// Token: 0x0400034B RID: 843
	[HideInInspector]
	[SerializeField]
	private PLQFPBQEPJD checkSprite;

	// Token: 0x0400034C RID: 844
	[HideInInspector]
	[SerializeField]
	private Animation checkAnimation;

	// Token: 0x0400034D RID: 845
	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver;

	// Token: 0x0400034E RID: 846
	[HideInInspector]
	[SerializeField]
	private string functionName = "OnActivate";

	// Token: 0x0400034F RID: 847
	[HideInInspector]
	[SerializeField]
	private bool startsChecked;

	// Token: 0x04000350 RID: 848
	private bool mIsActive = true;

	// Token: 0x04000351 RID: 849
	private bool mStarted;

	// Token: 0x02000089 RID: 137
	// (Invoke) Token: 0x060011E6 RID: 4582
	public delegate bool LMDIPLJPLBO(bool QDPCEEHDDPH);
}
