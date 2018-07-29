using System;
using UnityEngine;

// Token: 0x020000AA RID: 170
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Internal/Property Binding")]
public class EGOMLFPFGNO : MonoBehaviour
{
	// Token: 0x06001624 RID: 5668 RVA: 0x0000B94F File Offset: 0x00009B4F
	private void CPNQCCCNPMM()
	{
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnLateUpdate)
		{
			this.DQFMGKELDPD();
		}
	}

	// Token: 0x06001625 RID: 5669 RVA: 0x000A1940 File Offset: 0x0009FB40
	public void MPGOECBLPHM()
	{
		if (this.PBHPQFLMQDB != null && this.ILBCCCBJNCL != null && this.PBHPQFLMQDB.isValid && this.ILBCCCBJNCL.isValid)
		{
			if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.SourceUpdatesTarget)
			{
				this.ILBCCCBJNCL.KEOGBCIKPKF(this.PBHPQFLMQDB.INJNQNMOKKD());
			}
			else if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.SourceUpdatesTarget)
			{
				this.PBHPQFLMQDB.KEOGBCIKPKF(this.ILBCCCBJNCL.PHPEGGCCDMG());
			}
			else if (this.PBHPQFLMQDB.MEPLMGCCHLK() == this.ILBCCCBJNCL.MEPLMGCCHLK())
			{
				object obj = this.PBHPQFLMQDB.INJNQNMOKKD();
				if (this.MHHOJPCNJIH != null && this.MHHOJPCNJIH.Equals(obj))
				{
					obj = this.ILBCCCBJNCL.ELJODNKOCHO();
					if (!this.MHHOJPCNJIH.Equals(obj))
					{
						this.MHHOJPCNJIH = obj;
						this.PBHPQFLMQDB.PJMIKDIEGMB(obj);
					}
				}
				else
				{
					this.MHHOJPCNJIH = obj;
					this.ILBCCCBJNCL.KEOGBCIKPKF(obj);
				}
			}
		}
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x0000B960 File Offset: 0x00009B60
	private void HMQOONLDOLQ()
	{
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			this.MHQMEGHMHPF();
		}
	}

	// Token: 0x06001627 RID: 5671 RVA: 0x0000B971 File Offset: 0x00009B71
	private void HFEGBJEPMPQ()
	{
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			this.MPGOECBLPHM();
		}
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x0000B982 File Offset: 0x00009B82
	private void LMMGEGJCBJP()
	{
		this.DFBPEBCQNKG();
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x0000B999 File Offset: 0x00009B99
	private void LateUpdate()
	{
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnLateUpdate)
		{
			this.IQHIICBDICD();
		}
	}

	// Token: 0x0600162A RID: 5674 RVA: 0x0000B9AA File Offset: 0x00009BAA
	private void NFQENDCCDOF()
	{
		if (this.CGHLGBDQPDJ == (EGOMLFPFGNO.BEKIPEPGGQB)8)
		{
			this.MHQMEGHMHPF();
		}
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x000A1A50 File Offset: 0x0009FC50
	public void DFBPEBCQNKG()
	{
		if (this.PBHPQFLMQDB != null && this.ILBCCCBJNCL != null && this.PBHPQFLMQDB.JBPBQJCHLDJ() && this.ILBCCCBJNCL.isValid)
		{
			if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.SourceUpdatesTarget)
			{
				this.ILBCCCBJNCL.PJMIKDIEGMB(this.PBHPQFLMQDB.ELJODNKOCHO());
			}
			else if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.SourceUpdatesTarget)
			{
				this.PBHPQFLMQDB.KEOGBCIKPKF(this.ILBCCCBJNCL.ELJODNKOCHO());
			}
			else if (this.PBHPQFLMQDB.MEPLMGCCHLK() == this.ILBCCCBJNCL.MOJNMQHEDFL())
			{
				object obj = this.PBHPQFLMQDB.PHPEGGCCDMG();
				if (this.MHHOJPCNJIH != null && this.MHHOJPCNJIH.Equals(obj))
				{
					obj = this.ILBCCCBJNCL.ELJODNKOCHO();
					if (!this.MHHOJPCNJIH.Equals(obj))
					{
						this.MHHOJPCNJIH = obj;
						this.PBHPQFLMQDB.PJMIKDIEGMB(obj);
					}
				}
				else
				{
					this.MHHOJPCNJIH = obj;
					this.ILBCCCBJNCL.PJMIKDIEGMB(obj);
				}
			}
		}
	}

	// Token: 0x0600162C RID: 5676 RVA: 0x0000B9BB File Offset: 0x00009BBB
	private void IENHLKDIQBF()
	{
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnUpdate)
		{
			this.MPGOECBLPHM();
		}
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x0000B9CC File Offset: 0x00009BCC
	private void PGNNLOCNENM()
	{
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnFixedUpdate)
		{
			this.DQFMGKELDPD();
		}
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x0000B9DD File Offset: 0x00009BDD
	private void Start()
	{
		this.IQHIICBDICD();
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			base.enabled = false;
		}
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x0000B971 File Offset: 0x00009B71
	private void DHDCOBNGJDL()
	{
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			this.MPGOECBLPHM();
		}
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x0000B9F4 File Offset: 0x00009BF4
	private void QEENLDDQOEP()
	{
		if (this.PBHPQFLMQDB != null)
		{
			this.PBHPQFLMQDB.BJJGDIOLJMI();
		}
		if (this.ILBCCCBJNCL != null)
		{
			this.ILBCCCBJNCL.BJJGDIOLJMI();
		}
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x0000BA1C File Offset: 0x00009C1C
	private void FixedUpdate()
	{
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnFixedUpdate)
		{
			this.IQHIICBDICD();
		}
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x0000BA2D File Offset: 0x00009C2D
	private void Update()
	{
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnUpdate)
		{
			this.IQHIICBDICD();
		}
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x000A1B60 File Offset: 0x0009FD60
	public void PGEHDNOEOJB()
	{
		if (this.PBHPQFLMQDB != null && this.ILBCCCBJNCL != null && this.PBHPQFLMQDB.isValid && this.ILBCCCBJNCL.JBPBQJCHLDJ())
		{
			if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.SourceUpdatesTarget)
			{
				this.ILBCCCBJNCL.KEOGBCIKPKF(this.PBHPQFLMQDB.PHPEGGCCDMG());
			}
			else if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.SourceUpdatesTarget)
			{
				this.PBHPQFLMQDB.PJMIKDIEGMB(this.ILBCCCBJNCL.INJNQNMOKKD());
			}
			else if (this.PBHPQFLMQDB.MEPLMGCCHLK() == this.ILBCCCBJNCL.MEPLMGCCHLK())
			{
				object obj = this.PBHPQFLMQDB.PHPEGGCCDMG();
				if (this.MHHOJPCNJIH != null && this.MHHOJPCNJIH.Equals(obj))
				{
					obj = this.ILBCCCBJNCL.ELJODNKOCHO();
					if (!this.MHHOJPCNJIH.Equals(obj))
					{
						this.MHHOJPCNJIH = obj;
						this.PBHPQFLMQDB.KEOGBCIKPKF(obj);
					}
				}
				else
				{
					this.MHHOJPCNJIH = obj;
					this.ILBCCCBJNCL.PJMIKDIEGMB(obj);
				}
			}
		}
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x000A1C70 File Offset: 0x0009FE70
	[ContextMenu("Update Now")]
	public void IQHIICBDICD()
	{
		if (this.PBHPQFLMQDB != null && this.ILBCCCBJNCL != null && this.PBHPQFLMQDB.isValid && this.ILBCCCBJNCL.isValid)
		{
			if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.SourceUpdatesTarget)
			{
				this.ILBCCCBJNCL.PJMIKDIEGMB(this.PBHPQFLMQDB.INJNQNMOKKD());
			}
			else if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.TargetUpdatesSource)
			{
				this.PBHPQFLMQDB.PJMIKDIEGMB(this.ILBCCCBJNCL.INJNQNMOKKD());
			}
			else if (this.PBHPQFLMQDB.MEPLMGCCHLK() == this.ILBCCCBJNCL.MEPLMGCCHLK())
			{
				object obj = this.PBHPQFLMQDB.INJNQNMOKKD();
				if (this.MHHOJPCNJIH != null && this.MHHOJPCNJIH.Equals(obj))
				{
					obj = this.ILBCCCBJNCL.INJNQNMOKKD();
					if (!this.MHHOJPCNJIH.Equals(obj))
					{
						this.MHHOJPCNJIH = obj;
						this.PBHPQFLMQDB.PJMIKDIEGMB(obj);
					}
				}
				else
				{
					this.MHHOJPCNJIH = obj;
					this.ILBCCCBJNCL.PJMIKDIEGMB(obj);
				}
			}
		}
	}

	// Token: 0x06001635 RID: 5685 RVA: 0x000A1D80 File Offset: 0x0009FF80
	public void MHQMEGHMHPF()
	{
		if (this.PBHPQFLMQDB != null && this.ILBCCCBJNCL != null && this.PBHPQFLMQDB.JBPBQJCHLDJ() && this.ILBCCCBJNCL.isValid)
		{
			if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.SourceUpdatesTarget)
			{
				this.ILBCCCBJNCL.KEOGBCIKPKF(this.PBHPQFLMQDB.INJNQNMOKKD());
			}
			else if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.TargetUpdatesSource)
			{
				this.PBHPQFLMQDB.PJMIKDIEGMB(this.ILBCCCBJNCL.PHPEGGCCDMG());
			}
			else if (this.PBHPQFLMQDB.MOJNMQHEDFL() == this.ILBCCCBJNCL.MOJNMQHEDFL())
			{
				object obj = this.PBHPQFLMQDB.INJNQNMOKKD();
				if (this.MHHOJPCNJIH != null && this.MHHOJPCNJIH.Equals(obj))
				{
					obj = this.ILBCCCBJNCL.ELJODNKOCHO();
					if (!this.MHHOJPCNJIH.Equals(obj))
					{
						this.MHHOJPCNJIH = obj;
						this.PBHPQFLMQDB.PJMIKDIEGMB(obj);
					}
				}
				else
				{
					this.MHHOJPCNJIH = obj;
					this.ILBCCCBJNCL.PJMIKDIEGMB(obj);
				}
			}
		}
	}

	// Token: 0x06001636 RID: 5686 RVA: 0x0000BA3E File Offset: 0x00009C3E
	private void QNGIFIJOQML()
	{
		this.DFBPEBCQNKG();
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001637 RID: 5687 RVA: 0x0000BA55 File Offset: 0x00009C55
	private void IKHIQQKHILB()
	{
		this.MPGOECBLPHM();
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001638 RID: 5688 RVA: 0x0000B9F4 File Offset: 0x00009BF4
	private void EILLOQDLBGM()
	{
		if (this.PBHPQFLMQDB != null)
		{
			this.PBHPQFLMQDB.BJJGDIOLJMI();
		}
		if (this.ILBCCCBJNCL != null)
		{
			this.ILBCCCBJNCL.BJJGDIOLJMI();
		}
	}

	// Token: 0x06001639 RID: 5689 RVA: 0x0000BA6C File Offset: 0x00009C6C
	private void CLNOPBFEBID()
	{
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			this.PGEHDNOEOJB();
		}
	}

	// Token: 0x0600163A RID: 5690 RVA: 0x0000BA7D File Offset: 0x00009C7D
	private void QBGOGFJCLEP()
	{
		this.PGEHDNOEOJB();
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			base.enabled = true;
		}
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x0000BAAA File Offset: 0x00009CAA
	private void CKECNIHHBJE()
	{
		if (this.CGHLGBDQPDJ == (EGOMLFPFGNO.BEKIPEPGGQB)5)
		{
			this.DQFMGKELDPD();
		}
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x0000B9F4 File Offset: 0x00009BF4
	private void OnValidate()
	{
		if (this.PBHPQFLMQDB != null)
		{
			this.PBHPQFLMQDB.BJJGDIOLJMI();
		}
		if (this.ILBCCCBJNCL != null)
		{
			this.ILBCCCBJNCL.BJJGDIOLJMI();
		}
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x0000B9F4 File Offset: 0x00009BF4
	private void EOEHPNNBBMQ()
	{
		if (this.PBHPQFLMQDB != null)
		{
			this.PBHPQFLMQDB.BJJGDIOLJMI();
		}
		if (this.ILBCCCBJNCL != null)
		{
			this.ILBCCCBJNCL.BJJGDIOLJMI();
		}
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x0000B982 File Offset: 0x00009B82
	private void NDFNCDDDJPN()
	{
		this.DFBPEBCQNKG();
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x000A1E90 File Offset: 0x000A0090
	public void DQFMGKELDPD()
	{
		if (this.PBHPQFLMQDB != null && this.ILBCCCBJNCL != null && this.PBHPQFLMQDB.isValid && this.ILBCCCBJNCL.isValid)
		{
			if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.SourceUpdatesTarget)
			{
				this.ILBCCCBJNCL.KEOGBCIKPKF(this.PBHPQFLMQDB.ELJODNKOCHO());
			}
			else if (this.PECKDHFNOKI == EGOMLFPFGNO.MNCCMFFHQEQ.SourceUpdatesTarget)
			{
				this.PBHPQFLMQDB.KEOGBCIKPKF(this.ILBCCCBJNCL.ELJODNKOCHO());
			}
			else if (this.PBHPQFLMQDB.MOJNMQHEDFL() == this.ILBCCCBJNCL.MOJNMQHEDFL())
			{
				object obj = this.PBHPQFLMQDB.ELJODNKOCHO();
				if (this.MHHOJPCNJIH != null && this.MHHOJPCNJIH.Equals(obj))
				{
					obj = this.ILBCCCBJNCL.PHPEGGCCDMG();
					if (!this.MHHOJPCNJIH.Equals(obj))
					{
						this.MHHOJPCNJIH = obj;
						this.PBHPQFLMQDB.PJMIKDIEGMB(obj);
					}
				}
				else
				{
					this.MHHOJPCNJIH = obj;
					this.ILBCCCBJNCL.KEOGBCIKPKF(obj);
				}
			}
		}
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x0000BA3E File Offset: 0x00009C3E
	private void ODIJQBBOLFI()
	{
		this.DFBPEBCQNKG();
		if (this.CGHLGBDQPDJ == EGOMLFPFGNO.BEKIPEPGGQB.OnStart)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x0000BABB File Offset: 0x00009CBB
	private void LEHQJOJQECC()
	{
		if (this.CGHLGBDQPDJ == (EGOMLFPFGNO.BEKIPEPGGQB)5)
		{
			this.DFBPEBCQNKG();
		}
	}

	// Token: 0x0400041C RID: 1052
	public PropertyReference PBHPQFLMQDB;

	// Token: 0x0400041D RID: 1053
	public PropertyReference ILBCCCBJNCL;

	// Token: 0x0400041E RID: 1054
	public EGOMLFPFGNO.MNCCMFFHQEQ PECKDHFNOKI;

	// Token: 0x0400041F RID: 1055
	public EGOMLFPFGNO.BEKIPEPGGQB CGHLGBDQPDJ = EGOMLFPFGNO.BEKIPEPGGQB.OnUpdate;

	// Token: 0x04000420 RID: 1056
	public bool BLGIHNDKPED = true;

	// Token: 0x04000421 RID: 1057
	private object MHHOJPCNJIH;

	// Token: 0x020000AB RID: 171
	public enum BEKIPEPGGQB
	{
		// Token: 0x04000423 RID: 1059
		OnStart,
		// Token: 0x04000424 RID: 1060
		OnUpdate,
		// Token: 0x04000425 RID: 1061
		OnLateUpdate,
		// Token: 0x04000426 RID: 1062
		OnFixedUpdate
	}

	// Token: 0x020000AC RID: 172
	public enum MNCCMFFHQEQ
	{
		// Token: 0x04000428 RID: 1064
		SourceUpdatesTarget,
		// Token: 0x04000429 RID: 1065
		TargetUpdatesSource,
		// Token: 0x0400042A RID: 1066
		BiDirectional
	}
}
