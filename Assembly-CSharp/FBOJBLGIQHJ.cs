using System;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x02000393 RID: 915
public class FBOJBLGIQHJ : PlayableBehaviour
{
	// Token: 0x06007B1D RID: 31517 RVA: 0x003A5500 File Offset: 0x003A3700
	public virtual void IHHCDDJELLF(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.LGJIIFFDCPI() && num > behaviour.JMEHQFBJHFB())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 84f, 881f, 1353f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 883f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B1E RID: 31518 RVA: 0x003A55D0 File Offset: 0x003A37D0
	public virtual void GCKEOBHGFOC(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GMGQHQEBJIB() && num > behaviour.GQDJOLLIPDG())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 1759f, 790f, 1707f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 511f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B1F RID: 31519 RVA: 0x003A56A0 File Offset: 0x003A38A0
	public virtual void BJIKDGCJQDG(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.KQDIOLDHHDM() && num > behaviour.LGJIIFFDCPI())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 1546f, 1439f, 933f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 1552f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B20 RID: 31520 RVA: 0x003A5770 File Offset: 0x003A3970
	public virtual void FQBQBQPMGMO(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.BJEBDBJOOEP() && num > behaviour.JKDMIPICKHE())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 1221f, 1273f, 684f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1761f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B21 RID: 31521 RVA: 0x003A5840 File Offset: 0x003A3A40
	public virtual void GOBOLMFLFCC(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.HPMFMNKQBDN() && num > behaviour.GMGQHQEBJIB())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 1472f, 1085f, 191f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1520f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B22 RID: 31522 RVA: 0x003A5910 File Offset: 0x003A3B10
	public virtual void BLGILGPFFEL(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.JBPFIBLHBKD() && num > behaviour.JDOCNILHPDQ())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 1791f, 499f, 952f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 1904f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B23 RID: 31523 RVA: 0x003A59E0 File Offset: 0x003A3BE0
	public virtual void DKJBQFLEHFB(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.BMHIMGILEFB() && num > behaviour.JBPFIBLHBKD())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 607f, 1087f, 446f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 782f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B24 RID: 31524 RVA: 0x003A5AB0 File Offset: 0x003A3CB0
	public virtual void BHIOIMBLKJQ(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GMGQHQEBJIB() && num > behaviour.KGJIDLGGEMM())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 542f, 1348f, 1274f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 1819f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B25 RID: 31525 RVA: 0x003A5B80 File Offset: 0x003A3D80
	public virtual void HKQLJEQPNKC(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GMGQHQEBJIB() && num > behaviour.HJOMOPPECLI())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 787f, 1287f, 103f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 783f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B26 RID: 31526 RVA: 0x003A5C50 File Offset: 0x003A3E50
	public virtual void MCDFCQGPJFJ(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.JMEHQFBJHFB() && num > behaviour.LGJIIFFDCPI())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 979f, 1825f, 65f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1064f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B28 RID: 31528 RVA: 0x003A5D20 File Offset: 0x003A3F20
	public virtual void CNPLFIOEQOB(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.DPNQPPHPBLP() && num > behaviour.OOEMINQLJEG())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 221f, 1008f, 974f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 1762f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B29 RID: 31529 RVA: 0x003A5DF0 File Offset: 0x003A3FF0
	public virtual void HCFBHNIHNKM(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.HJOMOPPECLI() && num > behaviour.HJOMOPPECLI())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 556f, 1507f, 886f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 575f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B2A RID: 31530 RVA: 0x003A5EC0 File Offset: 0x003A40C0
	public virtual void GNOJEBJGJEQ(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.JMEHQFBJHFB() && num > behaviour.MQFGJGCHCNK())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 1562f, 1346f, 744f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 289f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B2B RID: 31531 RVA: 0x003A5F90 File Offset: 0x003A4190
	public override void ProcessFrame(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.ClipStartTime && num > behaviour.ClipStartTime)
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 1f, 1f, 0f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 0f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B2C RID: 31532 RVA: 0x003A6060 File Offset: 0x003A4260
	public virtual void LMBCGPHEFGP(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.JBPFIBLHBKD() && num > behaviour.GMGQHQEBJIB())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 21f, 812f, 1243f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 972f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B2D RID: 31533 RVA: 0x003A6130 File Offset: 0x003A4330
	public virtual void GHDNHGLINLF(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.OOEMINQLJEG() && num > behaviour.HPMFMNKQBDN())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 844f, 1548f, 34f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 853f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B2E RID: 31534 RVA: 0x003A6200 File Offset: 0x003A4400
	public virtual void OJJCECOEKQM(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.JBPFIBLHBKD() && num > behaviour.JBPFIBLHBKD())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 374f, 1590f, 1136f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 216f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B2F RID: 31535 RVA: 0x003A62D0 File Offset: 0x003A44D0
	public virtual void DDLCLBGBPLJ(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.OOEMINQLJEG() && num > behaviour.FCICFCOKOJE())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 1820f, 287f, 649f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 847f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B30 RID: 31536 RVA: 0x003A63A0 File Offset: 0x003A45A0
	public virtual void ONDKOHKLJPJ(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.DPNQPPHPBLP() && num > behaviour.HPMFMNKQBDN())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 1746f, 1616f, 533f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1290f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B31 RID: 31537 RVA: 0x003A6470 File Offset: 0x003A4670
	public virtual void OBBDGMGQLEM(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.DPNQPPHPBLP() && num > behaviour.JBPFIBLHBKD())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 523f, 999f, 1833f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1728f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B32 RID: 31538 RVA: 0x003A6540 File Offset: 0x003A4740
	public virtual void BGCFGEECBFN(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.JKDMIPICKHE() && num > behaviour.DLEJMNQNEQM())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 1092f, 1910f, 1444f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1703f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B33 RID: 31539 RVA: 0x003A6610 File Offset: 0x003A4810
	public virtual void BEPLIBIIDCE(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.KGJIDLGGEMM() && num > behaviour.ClipStartTime)
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 1626f, 1011f, 126f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 1777f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B34 RID: 31540 RVA: 0x003A66E0 File Offset: 0x003A48E0
	public virtual void IPMCINJHEED(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.JBPFIBLHBKD() && num > behaviour.LGJIIFFDCPI())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 83f, 1634f, 823f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 153f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B35 RID: 31541 RVA: 0x003A67B0 File Offset: 0x003A49B0
	public virtual void KOOEDGDFQEI(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.ClipStartTime && num > behaviour.HPMFMNKQBDN())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 1174f, 1583f, 387f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1560f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B36 RID: 31542 RVA: 0x003A6880 File Offset: 0x003A4A80
	public virtual void FGQHJEQNFIE(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.KGJIDLGGEMM() && num > behaviour.FCICFCOKOJE())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 1184f, 252f, 1369f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1661f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B37 RID: 31543 RVA: 0x003A6950 File Offset: 0x003A4B50
	public virtual void JMPCBOHDLDM(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.DLEJMNQNEQM() && num > behaviour.JKDMIPICKHE())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 219f, 545f, 906f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 807f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B38 RID: 31544 RVA: 0x003A6A20 File Offset: 0x003A4C20
	public virtual void MQDQBQEKIMC(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.DLEJMNQNEQM() && num > behaviour.KQDIOLDHHDM())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 497f, 1510f, 1241f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 394f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B39 RID: 31545 RVA: 0x003A6AF0 File Offset: 0x003A4CF0
	public virtual void FHLEBEFJICO(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GKMQLNFQGDB() && num > behaviour.LGJIIFFDCPI())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 169f, 617f, 419f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 572f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B3A RID: 31546 RVA: 0x003A6BC0 File Offset: 0x003A4DC0
	public virtual void PCNMLCHKHIG(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.HPMFMNKQBDN() && num > behaviour.JDOCNILHPDQ())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 1976f, 1188f, 1299f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 853f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B3B RID: 31547 RVA: 0x003A6C90 File Offset: 0x003A4E90
	public virtual void BKGCFIKIGPM(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GMGQHQEBJIB() && num > behaviour.DLEJMNQNEQM())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 207f, 773f, 161f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1705f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B3C RID: 31548 RVA: 0x003A6D60 File Offset: 0x003A4F60
	public virtual void BHCQDHIOEGC(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GQDJOLLIPDG() && num > behaviour.ClipStartTime)
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 262f, 475f, 1373f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 309f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B3D RID: 31549 RVA: 0x003A6E30 File Offset: 0x003A5030
	public virtual void QDGJNPDCIGE(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.BJEBDBJOOEP() && num > behaviour.ClipStartTime)
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 312f, 1850f, 216f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 662f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B3E RID: 31550 RVA: 0x003A6F00 File Offset: 0x003A5100
	public virtual void HBCPPHPJGPB(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.MQFGJGCHCNK() && num > behaviour.JDOCNILHPDQ())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 1596f, 1789f, 1508f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 1379f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B3F RID: 31551 RVA: 0x003A6FD0 File Offset: 0x003A51D0
	public virtual void BQPFEOKPNMQ(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.FCICFCOKOJE() && num > behaviour.LGJIIFFDCPI())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 124f, 1081f, 1468f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 584f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B40 RID: 31552 RVA: 0x003A70A0 File Offset: 0x003A52A0
	public virtual void MGKEQFGFMBP(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.KQDIOLDHHDM() && num > behaviour.KQDIOLDHHDM())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 259f, 824f, 1344f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 1611f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B41 RID: 31553 RVA: 0x003A7170 File Offset: 0x003A5370
	public virtual void JPFMPDJLQEB(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GMGQHQEBJIB() && num > behaviour.ClipStartTime)
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 1471f, 871f, 419f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 708f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B42 RID: 31554 RVA: 0x003A7240 File Offset: 0x003A5440
	public virtual void QHJJFOIMNOG(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.KQDIOLDHHDM() && num > behaviour.JDOCNILHPDQ())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 267f, 621f, 1864f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 1519f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B43 RID: 31555 RVA: 0x003A7310 File Offset: 0x003A5510
	public virtual void PKOJGHBMKQO(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GQDJOLLIPDG() && num > behaviour.FCICFCOKOJE())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 446f, 1426f, 434f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 104f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B44 RID: 31556 RVA: 0x003A73E0 File Offset: 0x003A55E0
	public virtual void JGNMJNJJPJH(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GMGQHQEBJIB() && num > behaviour.DPNQPPHPBLP())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 1859f, 6f, 281f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1260f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B45 RID: 31557 RVA: 0x003A74B0 File Offset: 0x003A56B0
	public virtual void EMHCQFHPLJO(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.JMEHQFBJHFB() && num > behaviour.GKMQLNFQGDB())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 228f, 350f, 238f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 776f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B46 RID: 31558 RVA: 0x003A7580 File Offset: 0x003A5780
	public virtual void CDKPNFFHMQF(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.LGJIIFFDCPI() && num > behaviour.KQDIOLDHHDM())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 453f, 1426f, 1565f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 1450f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B47 RID: 31559 RVA: 0x003A7650 File Offset: 0x003A5850
	public virtual void NPNGJEPGIGQ(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GMGQHQEBJIB() && num > behaviour.GQDJOLLIPDG())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 1752f, 1945f, 1662f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 677f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B48 RID: 31560 RVA: 0x003A7720 File Offset: 0x003A5920
	public virtual void PQBMCNIMMOB(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.BJEBDBJOOEP() && num > behaviour.BJEBDBJOOEP())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 826f, 316f, 743f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 832f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B49 RID: 31561 RVA: 0x003A77F0 File Offset: 0x003A59F0
	public virtual void NLIDMMQHMDK(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GKMQLNFQGDB() && num > behaviour.GKMQLNFQGDB())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 601f, 317f, 1964f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 306f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B4A RID: 31562 RVA: 0x003A78C0 File Offset: 0x003A5AC0
	public virtual void DKOQCEIBIGG(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(1);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 1; i < inputCount; i += 0)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.GKMQLNFQGDB() && num > behaviour.BMHIMGILEFB())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.GHFFHFCEENG().HJMBBIGEMNC(behaviour.cameraTarget, 539f, 1572f, 1098f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.GHFFHFCEENG().MJOCMCCPMFC(behaviour.cameraTarget, 152f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x06007B4B RID: 31563 RVA: 0x003A7990 File Offset: 0x003A5B90
	public virtual void FQBIGCJMKPB(Playable HCPFLGFJKIH, FrameData CEJKMEDQIDJ, object FDFLBDONFML)
	{
		int inputCount = HCPFLGFJKIH.GetInputCount<Playable>();
		Playable rootPlayable = HCPFLGFJKIH.GetGraph<Playable>().GetRootPlayable(0);
		float num = (float)rootPlayable.GetTime<Playable>();
		for (int i = 0; i < inputCount; i++)
		{
			PC2DAddOrRemoveCameraTargetBehaviour behaviour = ((ScriptPlayable<T>)HCPFLGFJKIH.GetInput(i)).GetBehaviour();
			if (Application.isPlaying && this.ICHCLCNOFPI <= behaviour.KQDIOLDHHDM() && num > behaviour.JBPFIBLHBKD())
			{
				if (behaviour.action == PPCLLLNJKGH.Add)
				{
					GNKDCOHMFEG.QOQONHOOLNE.HJMBBIGEMNC(behaviour.cameraTarget, 528f, 1494f, 1242f, default(Vector2));
				}
				else
				{
					GNKDCOHMFEG.QOQONHOOLNE.MJOCMCCPMFC(behaviour.cameraTarget, 1279f);
				}
			}
		}
		this.ICHCLCNOFPI = num;
	}

	// Token: 0x04001AA6 RID: 6822
	private float ICHCLCNOFPI;
}
