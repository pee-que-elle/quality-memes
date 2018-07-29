using System;
using UnityEngine;

// Token: 0x020001BB RID: 443
public class DoorAnimator : MonoBehaviour
{
	// Token: 0x06003849 RID: 14409 RVA: 0x001ABE18 File Offset: 0x001AA018
	private void Start()
	{
		this.anim = base.GetComponentInChildren<Animation>();
		this.anim.playAutomatically = false;
		AnimationClip clip = this.anim.GetClip("Take 001");
		float num = clip.length * clip.frameRate;
		clip.wrapMode = WrapMode.Once;
		this.anim.AddClip(clip, "Open", 0, (int)num / 2);
		this.anim.Play();
		this.anim["Open"].speed = 3f;
		this.anim.Rewind();
		this.anim.Stop();
		this.networkPlayers = CGOIPHKQMPD.QOQONHOOLNE;
		this.playerHandler = CNCJKLNHQBH.QOQONHOOLNE;
		this.isOpen = false;
		if (this.playerHandler != null)
		{
			Vector2 vector = new Vector2(base.transform.position.x, base.transform.position.z) - new Vector2(this.playerHandler.PPMJCBONMQJ.transform.position.x, this.playerHandler.PPMJCBONMQJ.transform.position.z);
			float num2 = vector.x * vector.x + vector.y * vector.y;
			if (num2 < 4f + this.ExtraSize)
			{
				this.Open(true);
			}
		}
	}

	// Token: 0x0600384A RID: 14410 RVA: 0x001ABF90 File Offset: 0x001AA190
	private void Update()
	{
		if (this.isOpen)
		{
			if (this.playerHandler != null)
			{
				Vector2 vector = new Vector2(base.transform.position.x, base.transform.position.z) - new Vector2(this.playerHandler.PPMJCBONMQJ.transform.position.x, this.playerHandler.PPMJCBONMQJ.transform.position.z);
				float num = vector.x * vector.x + vector.y * vector.y;
				if (num < 4f + this.ExtraSize)
				{
					return;
				}
			}
			for (int i = 0; i < this.networkPlayers.MHQMLCJDMMK.Count; i++)
			{
				if (this.networkPlayers.MHQMLCJDMMK[i] != null)
				{
					Vector2 vector2 = new Vector2(base.transform.position.x, base.transform.position.z) - new Vector2(this.networkPlayers.MHQMLCJDMMK[i].LMIPGJDLQDP.transform.position.x, this.networkPlayers.MHQMLCJDMMK[i].LMIPGJDLQDP.transform.position.z);
					float num2 = vector2.x * vector2.x + vector2.y * vector2.y;
					if (num2 < 4f + this.ExtraSize && !this.networkPlayers.MHQMLCJDMMK[i].LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().LJDKPJCDCCM)
					{
						return;
					}
				}
			}
			this.Close();
		}
	}

	// Token: 0x0600384B RID: 14411 RVA: 0x001AC184 File Offset: 0x001AA384
	public void Close()
	{
		if (!this.isOpen)
		{
			return;
		}
		if (this.anim != null)
		{
			if (!this.anim.isPlaying)
			{
				this.anim["Open"].time = this.anim["Open"].length;
				this.anim["Open"].speed = -2f;
				this.anim.Play("Open");
			}
			else
			{
				this.anim["Open"].speed = -2f;
			}
		}
		this.isOpen = false;
	}

	// Token: 0x0600384C RID: 14412 RVA: 0x001AC230 File Offset: 0x001AA430
	public void Open(bool checkforNPC = false)
	{
		if (this.isOpen)
		{
			return;
		}
		if (checkforNPC && MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ != null)
		{
			KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP((int)base.transform.position.x, -((int)base.transform.position.z + 1));
			if (nhgkgbgjefj != null && nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				return;
			}
			nhgkgbgjefj = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP((int)base.transform.position.x, -(int)base.transform.position.z);
			if (nhgkgbgjefj != null && nhgkgbgjefj.DNECDEOQKLP.KFNLCPGHQHK)
			{
				return;
			}
		}
		if (this.anim != null)
		{
			if (this.anim["Open"] == null)
			{
				return;
			}
			if (!this.anim.isPlaying)
			{
				this.anim["Open"].time = 0f;
				this.anim["Open"].speed = 2f;
				this.anim.Play("Open");
			}
			else
			{
				this.anim["Open"].speed = 2f;
			}
		}
		this.isOpen = true;
	}

	// Token: 0x04000D15 RID: 3349
	private CGOIPHKQMPD networkPlayers;

	// Token: 0x04000D16 RID: 3350
	private CNCJKLNHQBH playerHandler;

	// Token: 0x04000D17 RID: 3351
	public Animation anim;

	// Token: 0x04000D18 RID: 3352
	public float ExtraSize;

	// Token: 0x04000D19 RID: 3353
	private bool isOpen;
}
