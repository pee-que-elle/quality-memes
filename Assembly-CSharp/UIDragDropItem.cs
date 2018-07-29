using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000057 RID: 87
[AddComponentMenu("NGUI/Interaction/Drag and Drop Item")]
public class UIDragDropItem : MonoBehaviour
{
	// Token: 0x06000C08 RID: 3080 RVA: 0x00006E8E File Offset: 0x0000508E
	protected virtual void Awake()
	{
		this.mTrans = base.transform;
		this.mCollider = base.gameObject.GetComponent<Collider>();
		this.mCollider2D = base.gameObject.GetComponent<Collider2D>();
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x00006EBE File Offset: 0x000050BE
	protected virtual void OnDisable()
	{
		if (this.mDragging)
		{
			this.StopDragging(EMENMKHBPQE.QMPQFJMFQPB);
		}
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00006ED3 File Offset: 0x000050D3
	protected virtual void Start()
	{
		this.mButton = base.GetComponent<CFDMNELIJLO>();
		this.mDragScrollView = base.GetComponent<KBIJFBOECFE>();
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x00068998 File Offset: 0x00066B98
	protected virtual void OnPress(bool isPressed)
	{
		if (!isPressed && this.mDragStartTime < JMIOBJFFGBN.MOGLGJGFNDM - 0.2f)
		{
			this.StopDragging(EMENMKHBPQE.QMPQFJMFQPB);
		}
		if (this.interactable && EMENMKHBPQE.JQCODFPLPNJ != -2)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != -3)
			{
				if (isPressed)
				{
					if (!this.mPressed)
					{
						this.mTouch = EMENMKHBPQE.JHEDGGMDIEE;
						this.mDragStartTime = JMIOBJFFGBN.MOGLGJGFNDM + this.pressAndHoldDelay;
						this.mPressed = true;
					}
				}
				else if (this.mPressed && this.mTouch == EMENMKHBPQE.JHEDGGMDIEE)
				{
					this.mPressed = false;
					this.mTouch = null;
				}
				return;
			}
		}
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x00006EED File Offset: 0x000050ED
	protected virtual void Update()
	{
		if (this.restriction == UIDragDropItem.GDCGGGLKBJN.PressAndHold && this.mPressed && !this.mDragging && this.mDragStartTime < JMIOBJFFGBN.MOGLGJGFNDM)
		{
			this.StartDragging();
		}
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x00068A38 File Offset: 0x00066C38
	protected virtual void OnDragStart()
	{
		if (!this.interactable)
		{
			return;
		}
		if (base.enabled)
		{
			if (this.mTouch == EMENMKHBPQE.JHEDGGMDIEE)
			{
				if (this.restriction != UIDragDropItem.GDCGGGLKBJN.None)
				{
					if (this.restriction == UIDragDropItem.GDCGGGLKBJN.Horizontal)
					{
						Vector2 ilohlnlikdf = this.mTouch.ILOHLNLIKDF;
						if (Mathf.Abs(ilohlnlikdf.x) < Mathf.Abs(ilohlnlikdf.y))
						{
							return;
						}
					}
					else if (this.restriction == UIDragDropItem.GDCGGGLKBJN.Vertical)
					{
						Vector2 ilohlnlikdf2 = this.mTouch.ILOHLNLIKDF;
						if (Mathf.Abs(ilohlnlikdf2.x) > Mathf.Abs(ilohlnlikdf2.y))
						{
							return;
						}
					}
					else if (this.restriction == UIDragDropItem.GDCGGGLKBJN.PressAndHold)
					{
						return;
					}
				}
				this.StartDragging();
				return;
			}
		}
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x00068AE4 File Offset: 0x00066CE4
	public virtual void StartDragging()
	{
		if (!this.interactable)
		{
			return;
		}
		if (!this.mDragging)
		{
			if (this.cloneOnDrag)
			{
				this.mPressed = false;
				GameObject gameObject;
				if (this.cloneObject != null)
				{
					gameObject = base.transform.parent.gameObject.BFCKNMFEBDM(this.cloneObject);
					gameObject.transform.position = EMENMKHBPQE.DKIMLEKEFCB.point;
				}
				else
				{
					gameObject = base.transform.parent.gameObject.BFCKNMFEBDM(base.gameObject);
					gameObject.transform.localPosition = base.transform.localPosition;
				}
				gameObject.transform.localRotation = base.transform.localRotation;
				gameObject.transform.localScale = base.transform.localScale;
				PBJKDKBOLHO component = gameObject.GetComponent<PBJKDKBOLHO>();
				if (component != null)
				{
					component.IDEOONDHNEL = base.GetComponent<PBJKDKBOLHO>().IDEOONDHNEL;
				}
				if (this.mTouch != null && this.mTouch.KCICOJFDCPQ == base.gameObject)
				{
					this.mTouch.OMQCQCBLQGJ = gameObject;
					this.mTouch.KCICOJFDCPQ = gameObject;
					this.mTouch.HKGQKLHJKMB = gameObject;
					this.mTouch.CIDFMGENPFQ = gameObject;
				}
				UIDragDropItem component2 = gameObject.GetComponent<UIDragDropItem>();
				component2.mTouch = this.mTouch;
				component2.mPressed = true;
				component2.mDragging = true;
				component2.Start();
				component2.OnClone(base.gameObject);
				component2.GetClone(gameObject, base.gameObject);
				component2.OnDragDropStart();
				if (EMENMKHBPQE.JHEDGGMDIEE == null)
				{
					EMENMKHBPQE.JHEDGGMDIEE = this.mTouch;
				}
				this.mTouch = null;
				EMENMKHBPQE.EHDBBNFQIBL(base.gameObject, "OnPress", false);
				EMENMKHBPQE.EHDBBNFQIBL(base.gameObject, "OnHover", false);
			}
			else
			{
				this.mDragging = true;
				this.OnDragDropStart();
			}
		}
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void OnClone(GameObject original)
	{
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void GetClone(GameObject getclone, GameObject original)
	{
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00068CC4 File Offset: 0x00066EC4
	protected virtual void OnDrag(Vector2 delta)
	{
		if (!this.interactable)
		{
			return;
		}
		if (this.mDragging && base.enabled)
		{
			if (this.mTouch == EMENMKHBPQE.JHEDGGMDIEE)
			{
				if (this.mRoot != null)
				{
					this.OnDragDropMove(delta * this.mRoot.PNBFQDLQENI);
				}
				else
				{
					this.OnDragDropMove(delta);
				}
				return;
			}
		}
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x00006F1B File Offset: 0x0000511B
	protected virtual void OnDragEnd()
	{
		if (!this.interactable)
		{
			return;
		}
		if (base.enabled)
		{
			if (this.mTouch == EMENMKHBPQE.JHEDGGMDIEE)
			{
				this.StopDragging(EMENMKHBPQE.QMPQFJMFQPB);
				return;
			}
		}
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x00006F49 File Offset: 0x00005149
	public void StopDragging(GameObject go)
	{
		if (this.mDragging)
		{
			this.mDragging = false;
			this.OnDragDropRelease(go);
		}
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x00068D28 File Offset: 0x00066F28
	protected virtual void OnDragDropStart()
	{
		this.adjustment = 0f;
		if (!UIDragDropItem.draggedItems.Contains(this))
		{
			UIDragDropItem.draggedItems.Add(this);
		}
		if (this.mDragScrollView != null)
		{
			this.mDragScrollView.enabled = false;
		}
		if (this.mButton != null)
		{
			this.mButton.GGBPLMICFHN = false;
		}
		else if (this.mCollider != null)
		{
			this.mCollider.enabled = false;
		}
		else if (this.mCollider2D != null)
		{
			this.mCollider2D.enabled = false;
		}
		this.mParent = this.mTrans.parent;
		this.mRoot = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(this.mParent);
		this.mGrid = IKBQNBHOJJB.BBDJCHKMCPI<BHLIGEGNFHG>(this.mParent);
		this.mTable = IKBQNBHOJJB.BBDJCHKMCPI<JFDJLDBQQKC>(this.mParent);
		if (PPCCQBMDFCF.QOBPIJDBNGL != null)
		{
			this.mTrans.parent = PPCCQBMDFCF.QOBPIJDBNGL;
		}
		Vector3 localPosition = this.mTrans.localPosition;
		localPosition.z = 0f;
		this.mTrans.localPosition = localPosition;
		JDMOPNEKJII component = base.GetComponent<JDMOPNEKJII>();
		if (component != null)
		{
			component.enabled = false;
		}
		QHQFGHKIMMF component2 = base.GetComponent<QHQFGHKIMMF>();
		if (component2 != null)
		{
			component2.enabled = false;
		}
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.mTable != null)
		{
			this.mTable.CLQFFBMLIQH = true;
		}
		if (this.mGrid != null)
		{
			this.mGrid.CLQFFBMLIQH = true;
		}
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x00068EB8 File Offset: 0x000670B8
	protected virtual void OnDragDropMove(Vector2 delta)
	{
		if (this.adjustment == 0f)
		{
			this.adjustment = GKDCBJPLQLQ.CLBGPGKBPQK(this.mTrans.gameObject);
		}
		delta = new Vector2(delta.x * this.adjustment, delta.y * this.adjustment);
		this.mTrans.localPosition += this.mTrans.InverseTransformDirection(delta);
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x00068F34 File Offset: 0x00067134
	protected virtual void OnDragDropRelease(GameObject surface)
	{
		if (!this.cloneOnDrag)
		{
			KBIJFBOECFE[] componentsInChildren = base.GetComponentsInChildren<KBIJFBOECFE>();
			foreach (KBIJFBOECFE kbijfboecfe in componentsInChildren)
			{
				kbijfboecfe.EPDKEQFDCDC = null;
			}
			if (this.mButton != null)
			{
				this.mButton.GGBPLMICFHN = true;
			}
			else if (this.mCollider != null)
			{
				this.mCollider.enabled = true;
			}
			else if (this.mCollider2D != null)
			{
				this.mCollider2D.enabled = true;
			}
			KMPQJILNION kmpqjilnion = (!surface) ? null : IKBQNBHOJJB.BBDJCHKMCPI<KMPQJILNION>(surface);
			if (kmpqjilnion != null)
			{
				this.mTrans.parent = ((!(kmpqjilnion.JBNIPKEJEFP != null)) ? kmpqjilnion.transform : kmpqjilnion.JBNIPKEJEFP);
				Vector3 localPosition = this.mTrans.localPosition;
				localPosition.z = 0f;
				this.mTrans.localPosition = localPosition;
			}
			else
			{
				this.mTrans.parent = this.mParent;
			}
			this.mParent = this.mTrans.parent;
			this.mGrid = IKBQNBHOJJB.BBDJCHKMCPI<BHLIGEGNFHG>(this.mParent);
			this.mTable = IKBQNBHOJJB.BBDJCHKMCPI<JFDJLDBQQKC>(this.mParent);
			if (this.mDragScrollView != null)
			{
				base.Invoke("EnableDragScrollView", 0.001f);
			}
			IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
			if (this.mTable != null)
			{
				this.mTable.CLQFFBMLIQH = true;
			}
			if (this.mGrid != null)
			{
				this.mGrid.CLQFFBMLIQH = true;
			}
		}
		else
		{
			IKBQNBHOJJB.MOPPIIOIIDM(base.gameObject);
		}
		this.OnDragDropEnd();
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x00006F61 File Offset: 0x00005161
	protected virtual void OnDragDropEnd()
	{
		UIDragDropItem.draggedItems.Remove(this);
		this.adjustment = 0f;
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00006F7A File Offset: 0x0000517A
	protected void EnableDragScrollView()
	{
		if (this.mDragScrollView != null)
		{
			this.mDragScrollView.enabled = true;
		}
	}

	// Token: 0x040001A5 RID: 421
	public UIDragDropItem.GDCGGGLKBJN restriction;

	// Token: 0x040001A6 RID: 422
	public bool cloneOnDrag;

	// Token: 0x040001A7 RID: 423
	public GameObject cloneObject;

	// Token: 0x040001A8 RID: 424
	[HideInInspector]
	public float pressAndHoldDelay = 1f;

	// Token: 0x040001A9 RID: 425
	public bool interactable = true;

	// Token: 0x040001AA RID: 426
	[NonSerialized]
	protected Transform mTrans;

	// Token: 0x040001AB RID: 427
	[NonSerialized]
	protected Transform mParent;

	// Token: 0x040001AC RID: 428
	[NonSerialized]
	protected Collider mCollider;

	// Token: 0x040001AD RID: 429
	[NonSerialized]
	protected Collider2D mCollider2D;

	// Token: 0x040001AE RID: 430
	[NonSerialized]
	protected CFDMNELIJLO mButton;

	// Token: 0x040001AF RID: 431
	[NonSerialized]
	protected GKDCBJPLQLQ mRoot;

	// Token: 0x040001B0 RID: 432
	[NonSerialized]
	protected BHLIGEGNFHG mGrid;

	// Token: 0x040001B1 RID: 433
	[NonSerialized]
	protected JFDJLDBQQKC mTable;

	// Token: 0x040001B2 RID: 434
	[NonSerialized]
	protected float mDragStartTime;

	// Token: 0x040001B3 RID: 435
	[NonSerialized]
	protected KBIJFBOECFE mDragScrollView;

	// Token: 0x040001B4 RID: 436
	[NonSerialized]
	protected bool mPressed;

	// Token: 0x040001B5 RID: 437
	[NonSerialized]
	protected bool mDragging;

	// Token: 0x040001B6 RID: 438
	[NonSerialized]
	protected EMENMKHBPQE.LFHKIJNGPFF mTouch;

	// Token: 0x040001B7 RID: 439
	public static List<UIDragDropItem> draggedItems = new List<UIDragDropItem>();

	// Token: 0x040001B8 RID: 440
	private float adjustment;

	// Token: 0x02000058 RID: 88
	public enum GDCGGGLKBJN
	{
		// Token: 0x040001BA RID: 442
		None,
		// Token: 0x040001BB RID: 443
		Horizontal,
		// Token: 0x040001BC RID: 444
		Vertical,
		// Token: 0x040001BD RID: 445
		PressAndHold
	}
}
