using System;
using UnityEngine;

// Token: 0x0200005D RID: 93
[AddComponentMenu("NGUI/Interaction/Drag-Resize Widget")]
public class UIDragResize : MonoBehaviour
{
	// Token: 0x06000CFE RID: 3326 RVA: 0x0007034C File Offset: 0x0006E54C
	private void OnDragStart()
	{
		if (this.target != null)
		{
			Vector3[] pmcnqichcle = this.target.PMCNQICHCLE;
			this.mPlane = new Plane(pmcnqichcle[0], pmcnqichcle[1], pmcnqichcle[3]);
			Ray blhkbchjnqe = EMENMKHBPQE.BLHKBCHJNQE;
			float distance;
			if (this.mPlane.Raycast(blhkbchjnqe, out distance))
			{
				this.mRayPos = blhkbchjnqe.GetPoint(distance);
				this.mLocalPos = this.target.CGDFDPHIENG.localPosition;
				this.mWidth = this.target.KJGMGPCEJJD;
				this.mHeight = this.target.DFKQMMIQDOO;
				this.mDragging = true;
			}
		}
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00070408 File Offset: 0x0006E608
	private void OnDrag(Vector2 delta)
	{
		if (this.mDragging && this.target != null)
		{
			Ray blhkbchjnqe = EMENMKHBPQE.BLHKBCHJNQE;
			float distance;
			if (this.mPlane.Raycast(blhkbchjnqe, out distance))
			{
				Transform cgdfdphieng = this.target.CGDFDPHIENG;
				cgdfdphieng.localPosition = this.mLocalPos;
				this.target.KJGMGPCEJJD = this.mWidth;
				this.target.DFKQMMIQDOO = this.mHeight;
				Vector3 b = blhkbchjnqe.GetPoint(distance) - this.mRayPos;
				cgdfdphieng.position += b;
				Vector3 vector = Quaternion.Inverse(cgdfdphieng.localRotation) * (cgdfdphieng.localPosition - this.mLocalPos);
				cgdfdphieng.localPosition = this.mLocalPos;
				JNNGOIIKENH.LNQGLIIFOOC(this.target, this.pivot, vector.x, vector.y, this.minWidth, this.minHeight, this.maxWidth, this.maxHeight);
				if (this.updateAnchors)
				{
					this.target.BroadcastMessage("UpdateAnchors");
				}
			}
		}
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x00007239 File Offset: 0x00005439
	private void OnDragEnd()
	{
		this.mDragging = false;
	}

	// Token: 0x040001E3 RID: 483
	public ENFMCDNLEQQ target;

	// Token: 0x040001E4 RID: 484
	public ENFMCDNLEQQ.GGBIQFIQQCM pivot = ENFMCDNLEQQ.GGBIQFIQQCM.BottomRight;

	// Token: 0x040001E5 RID: 485
	public int minWidth = 100;

	// Token: 0x040001E6 RID: 486
	public int minHeight = 100;

	// Token: 0x040001E7 RID: 487
	public int maxWidth = 100000;

	// Token: 0x040001E8 RID: 488
	public int maxHeight = 100000;

	// Token: 0x040001E9 RID: 489
	public bool updateAnchors;

	// Token: 0x040001EA RID: 490
	private Plane mPlane;

	// Token: 0x040001EB RID: 491
	private Vector3 mRayPos;

	// Token: 0x040001EC RID: 492
	private Vector3 mLocalPos;

	// Token: 0x040001ED RID: 493
	private int mWidth;

	// Token: 0x040001EE RID: 494
	private int mHeight;

	// Token: 0x040001EF RID: 495
	private bool mDragging;
}
