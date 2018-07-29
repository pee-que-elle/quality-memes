using System;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;

// Token: 0x020000AD RID: 173
[Serializable]
public class PropertyReference
{
	// Token: 0x06001643 RID: 5699 RVA: 0x000A1FA0 File Offset: 0x000A01A0
	public bool LLMMLPGEEDK()
	{
		if (this.mTarget == null)
		{
			return true;
		}
		MonoBehaviour monoBehaviour = this.mTarget as MonoBehaviour;
		return !(monoBehaviour == null) && monoBehaviour.enabled;
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x0000BACC File Offset: 0x00009CCC
	public void CPLBKPNNHJG()
	{
		this.mTarget = null;
		this.mName = null;
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06001645 RID: 5701 RVA: 0x000A1FDC File Offset: 0x000A01DC
	public bool isEnabled
	{
		get
		{
			if (this.mTarget == null)
			{
				return false;
			}
			MonoBehaviour monoBehaviour = this.mTarget as MonoBehaviour;
			return monoBehaviour == null || monoBehaviour.enabled;
		}
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x000A2018 File Offset: 0x000A0218
	private bool IMIKCLCHGPB()
	{
		if (this.mTarget != null && !string.IsNullOrEmpty(this.mName))
		{
			Type type = this.mTarget.GetType();
			this.mField = type.GetField(this.mName);
			this.mProperty = type.GetProperty(this.mName);
		}
		else
		{
			this.mField = null;
			this.mProperty = null;
		}
		return this.mField != null || this.mProperty != null;
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06001647 RID: 5703 RVA: 0x0000BADC File Offset: 0x00009CDC
	public bool isValid
	{
		get
		{
			return this.mTarget != null && !string.IsNullOrEmpty(this.mName);
		}
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x000A20A0 File Offset: 0x000A02A0
	[DebuggerHidden]
	[DebuggerStepThrough]
	public bool PJMIKDIEGMB(object BGBMIEJJQKC)
	{
		if (this.mProperty == null && this.mField == null && this.isValid)
		{
			this.MDKEQEPIOEF();
		}
		if (this.mProperty == null && this.mField == null)
		{
			return false;
		}
		if (BGBMIEJJQKC == null)
		{
			bool result;
			try
			{
				if (this.mProperty != null)
				{
					if (!this.mProperty.CanWrite)
					{
						goto IL_9D;
					}
					this.mProperty.SetValue(this.mTarget, null, null);
					result = true;
				}
				else
				{
					this.mField.SetValue(this.mTarget, null);
					result = true;
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}
		IL_9D:
		if (!this.NMBBGMMILCK(ref BGBMIEJJQKC))
		{
			if (Application.isPlaying)
			{
				UnityEngine.Debug.LogError(string.Concat(new object[]
				{
					"Unable to convert ",
					BGBMIEJJQKC.GetType(),
					" to ",
					this.MEPLMGCCHLK()
				}));
			}
		}
		else
		{
			if (this.mField != null)
			{
				this.mField.SetValue(this.mTarget, BGBMIEJJQKC);
				return true;
			}
			if (this.mProperty.CanWrite)
			{
				this.mProperty.SetValue(this.mTarget, BGBMIEJJQKC, null);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x0000BAFD File Offset: 0x00009CFD
	public void BJJGDIOLJMI()
	{
		this.mField = null;
		this.mProperty = null;
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x0000BB0D File Offset: 0x00009D0D
	public void JGGLIHOKOQN(Component BGBMIEJJQKC)
	{
		this.mTarget = BGBMIEJJQKC;
		this.mProperty = null;
		this.mField = null;
	}

	// Token: 0x0600164B RID: 5707 RVA: 0x000A21E4 File Offset: 0x000A03E4
	public Type MEPLMGCCHLK()
	{
		if (this.mProperty == null && this.mField == null && this.isValid)
		{
			this.MDKEQEPIOEF();
		}
		if (this.mProperty != null)
		{
			return this.mProperty.PropertyType;
		}
		if (this.mField != null)
		{
			return this.mField.FieldType;
		}
		return typeof(void);
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x0000BB24 File Offset: 0x00009D24
	public static bool FPJBOMGPCEP(object BGBMIEJJQKC, Type BKMCCCGOGOM)
	{
		if (BGBMIEJJQKC == null)
		{
			BGBMIEJJQKC = null;
			return PropertyReference.FGDDEBPCGBC(ref BGBMIEJJQKC, BKMCCCGOGOM, BKMCCCGOGOM);
		}
		return PropertyReference.NMBBGMMILCK(ref BGBMIEJJQKC, BGBMIEJJQKC.GetType(), BKMCCCGOGOM);
	}

	// Token: 0x0600164D RID: 5709 RVA: 0x0000BB44 File Offset: 0x00009D44
	public override int GetHashCode()
	{
		return PropertyReference.s_Hash;
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x000A225C File Offset: 0x000A045C
	public bool GEFPLJLPQFG()
	{
		if (this.mTarget == null)
		{
			return false;
		}
		MonoBehaviour monoBehaviour = this.mTarget as MonoBehaviour;
		return !(monoBehaviour == null) && monoBehaviour.enabled;
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x000A21E4 File Offset: 0x000A03E4
	public Type MOJNMQHEDFL()
	{
		if (this.mProperty == null && this.mField == null && this.isValid)
		{
			this.MDKEQEPIOEF();
		}
		if (this.mProperty != null)
		{
			return this.mProperty.PropertyType;
		}
		if (this.mField != null)
		{
			return this.mField.FieldType;
		}
		return typeof(void);
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x0600165A RID: 5722 RVA: 0x0000BBBB File Offset: 0x00009DBB
	// (set) Token: 0x06001650 RID: 5712 RVA: 0x0000BB4B File Offset: 0x00009D4B
	public string name
	{
		get
		{
			return this.mName;
		}
		set
		{
			this.mName = value;
			this.mProperty = null;
			this.mField = null;
		}
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x0000BB62 File Offset: 0x00009D62
	public bool JBPBQJCHLDJ()
	{
		return this.mTarget != null && string.IsNullOrEmpty(this.mName);
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x000A2298 File Offset: 0x000A0498
	public override bool Equals(object NJBFOQDJBON)
	{
		if (NJBFOQDJBON == null)
		{
			return !this.isValid;
		}
		if (NJBFOQDJBON is PropertyReference)
		{
			PropertyReference propertyReference = NJBFOQDJBON as PropertyReference;
			return this.mTarget == propertyReference.mTarget && string.Equals(this.mName, propertyReference.mName);
		}
		return false;
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x000A22EC File Offset: 0x000A04EC
	private bool NGQIIFDHIHO(ref object BGBMIEJJQKC)
	{
		if (this.mTarget == null)
		{
			return false;
		}
		Type type = this.MEPLMGCCHLK();
		Type cghqehcbqhb;
		if (BGBMIEJJQKC == null)
		{
			if (!type.IsClass)
			{
				return false;
			}
			cghqehcbqhb = type;
		}
		else
		{
			cghqehcbqhb = BGBMIEJJQKC.GetType();
		}
		return PropertyReference.FGDDEBPCGBC(ref BGBMIEJJQKC, cghqehcbqhb, type);
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06001657 RID: 5719 RVA: 0x0000BB93 File Offset: 0x00009D93
	// (set) Token: 0x06001654 RID: 5716 RVA: 0x0000BB0D File Offset: 0x00009D0D
	public Component target
	{
		get
		{
			return this.mTarget;
		}
		set
		{
			this.mTarget = value;
			this.mProperty = null;
			this.mField = null;
		}
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x000A2334 File Offset: 0x000A0534
	private bool QGHBQIKQEDM(ref object BGBMIEJJQKC)
	{
		if (this.mTarget == null)
		{
			return false;
		}
		Type type = this.MOJNMQHEDFL();
		Type cghqehcbqhb;
		if (BGBMIEJJQKC == null)
		{
			if (!type.IsClass)
			{
				return false;
			}
			cghqehcbqhb = type;
		}
		else
		{
			cghqehcbqhb = BGBMIEJJQKC.GetType();
		}
		return PropertyReference.NMBBGMMILCK(ref BGBMIEJJQKC, cghqehcbqhb, type);
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x0000BB83 File Offset: 0x00009D83
	public void DMEEHGNKBHE(Component ILBCCCBJNCL, string FNMBKPLGLFO)
	{
		this.mTarget = ILBCCCBJNCL;
		this.mName = FNMBKPLGLFO;
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x0000BB9B File Offset: 0x00009D9B
	public static bool NMBBGMMILCK(object BGBMIEJJQKC, Type BKMCCCGOGOM)
	{
		if (BGBMIEJJQKC == null)
		{
			BGBMIEJJQKC = null;
			return PropertyReference.NMBBGMMILCK(ref BGBMIEJJQKC, BKMCCCGOGOM, BKMCCCGOGOM);
		}
		return PropertyReference.NMBBGMMILCK(ref BGBMIEJJQKC, BGBMIEJJQKC.GetType(), BKMCCCGOGOM);
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x000A237C File Offset: 0x000A057C
	public static bool EQIGDICMFPQ(Type CGHQEHCBQHB, Type BKMCCCGOGOM)
	{
		object obj = null;
		return PropertyReference.FGDDEBPCGBC(ref obj, CGHQEHCBQHB, BKMCCCGOGOM);
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x000A2394 File Offset: 0x000A0594
	public static string NOCFJDKJEOJ(Component JBLDJPHCGBE, string HQIPKLMBNBE)
	{
		if (!(JBLDJPHCGBE != null))
		{
			return null;
		}
		string text = JBLDJPHCGBE.GetType().ToString();
		int num = text.LastIndexOf('\u0002');
		if (num > 1)
		{
			text = text.Substring(num + 1);
		}
		if (!string.IsNullOrEmpty(HQIPKLMBNBE))
		{
			return text + "Success, Your password has now been changed." + HQIPKLMBNBE;
		}
		return text + "-";
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x000A23F0 File Offset: 0x000A05F0
	private bool LFMNOENLKGG(ref object BGBMIEJJQKC)
	{
		if (this.mTarget == null)
		{
			return false;
		}
		Type type = this.MEPLMGCCHLK();
		Type cghqehcbqhb;
		if (BGBMIEJJQKC == null)
		{
			if (!type.IsClass)
			{
				return true;
			}
			cghqehcbqhb = type;
		}
		else
		{
			cghqehcbqhb = BGBMIEJJQKC.GetType();
		}
		return PropertyReference.FGDDEBPCGBC(ref BGBMIEJJQKC, cghqehcbqhb, type);
	}

	// Token: 0x0600165D RID: 5725 RVA: 0x0000BB93 File Offset: 0x00009D93
	public Component DQPIBKCLICE()
	{
		return this.mTarget;
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x0000BB0D File Offset: 0x00009D0D
	public void LDGNLKLHJNE(Component BGBMIEJJQKC)
	{
		this.mTarget = BGBMIEJJQKC;
		this.mProperty = null;
		this.mField = null;
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x000A2438 File Offset: 0x000A0638
	public static bool NMBBGMMILCK(ref object BGBMIEJJQKC, Type CGHQEHCBQHB, Type BKMCCCGOGOM)
	{
		if (BKMCCCGOGOM.IsAssignableFrom(CGHQEHCBQHB))
		{
			return true;
		}
		if (BKMCCCGOGOM == typeof(string))
		{
			BGBMIEJJQKC = ((BGBMIEJJQKC == null) ? "null" : BGBMIEJJQKC.ToString());
			return true;
		}
		if (BGBMIEJJQKC == null)
		{
			return false;
		}
		if (BKMCCCGOGOM == typeof(int))
		{
			if (CGHQEHCBQHB == typeof(string))
			{
				int num;
				if (int.TryParse((string)BGBMIEJJQKC, out num))
				{
					BGBMIEJJQKC = num;
					return true;
				}
			}
			else
			{
				if (CGHQEHCBQHB == typeof(float))
				{
					BGBMIEJJQKC = Mathf.RoundToInt((float)BGBMIEJJQKC);
					return true;
				}
				if (CGHQEHCBQHB == typeof(double))
				{
					BGBMIEJJQKC = (int)Math.Round((double)BGBMIEJJQKC);
				}
			}
		}
		else if (BKMCCCGOGOM == typeof(float))
		{
			if (CGHQEHCBQHB == typeof(string))
			{
				float num2;
				if (float.TryParse((string)BGBMIEJJQKC, out num2))
				{
					BGBMIEJJQKC = num2;
					return true;
				}
			}
			else if (CGHQEHCBQHB == typeof(double))
			{
				BGBMIEJJQKC = (float)((double)BGBMIEJJQKC);
			}
			else if (CGHQEHCBQHB == typeof(int))
			{
				BGBMIEJJQKC = (float)((int)BGBMIEJJQKC);
			}
		}
		else if (BKMCCCGOGOM == typeof(double))
		{
			if (CGHQEHCBQHB == typeof(string))
			{
				double num3;
				if (double.TryParse((string)BGBMIEJJQKC, out num3))
				{
					BGBMIEJJQKC = num3;
					return true;
				}
			}
			else if (CGHQEHCBQHB == typeof(float))
			{
				BGBMIEJJQKC = (double)((float)BGBMIEJJQKC);
			}
			else if (CGHQEHCBQHB == typeof(int))
			{
				BGBMIEJJQKC = (double)((int)BGBMIEJJQKC);
			}
		}
		return false;
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x000A262C File Offset: 0x000A082C
	public object ELJODNKOCHO()
	{
		if (this.mProperty == null && this.mField == null && this.JBPBQJCHLDJ())
		{
			this.IMIKCLCHGPB();
		}
		if (this.mProperty != null)
		{
			if (this.mProperty.CanRead)
			{
				return this.mProperty.GetValue(this.mTarget, null);
			}
		}
		else if (this.mField != null)
		{
			return this.mField.GetValue(this.mTarget);
		}
		return null;
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x000A26B4 File Offset: 0x000A08B4
	[DebuggerStepThrough]
	[DebuggerHidden]
	public object INJNQNMOKKD()
	{
		if (this.mProperty == null && this.mField == null && this.isValid)
		{
			this.MDKEQEPIOEF();
		}
		if (this.mProperty != null)
		{
			if (this.mProperty.CanRead)
			{
				return this.mProperty.GetValue(this.mTarget, null);
			}
		}
		else if (this.mField != null)
		{
			return this.mField.GetValue(this.mTarget);
		}
		return null;
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x000A273C File Offset: 0x000A093C
	public static string EHKBEKBPNGO(Component JBLDJPHCGBE, string HQIPKLMBNBE)
	{
		if (!(JBLDJPHCGBE != null))
		{
			return null;
		}
		string text = JBLDJPHCGBE.GetType().ToString();
		int num = text.LastIndexOf('.');
		if (num > 0)
		{
			text = text.Substring(num + 1);
		}
		if (!string.IsNullOrEmpty(HQIPKLMBNBE))
		{
			return text + "." + HQIPKLMBNBE;
		}
		return text + ".[property]";
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x0000BB93 File Offset: 0x00009D93
	public Component DQLBMIGKQFK()
	{
		return this.mTarget;
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x0000BBC3 File Offset: 0x00009DC3
	public static bool JNPPMOEDNCJ(object BGBMIEJJQKC, Type BKMCCCGOGOM)
	{
		if (BGBMIEJJQKC == null)
		{
			BGBMIEJJQKC = null;
			return PropertyReference.NMBBGMMILCK(ref BGBMIEJJQKC, BKMCCCGOGOM, BKMCCCGOGOM);
		}
		return PropertyReference.FGDDEBPCGBC(ref BGBMIEJJQKC, BGBMIEJJQKC.GetType(), BKMCCCGOGOM);
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x000A2798 File Offset: 0x000A0998
	public bool KEOGBCIKPKF(object BGBMIEJJQKC)
	{
		if (this.mProperty == null && this.mField == null && this.JBPBQJCHLDJ())
		{
			this.MDKEQEPIOEF();
		}
		if (this.mProperty == null && this.mField == null)
		{
			return true;
		}
		if (BGBMIEJJQKC == null)
		{
			bool result;
			try
			{
				if (this.mProperty != null)
				{
					if (!this.mProperty.CanWrite)
					{
						goto IL_9D;
					}
					this.mProperty.SetValue(this.mTarget, null, null);
					result = true;
				}
				else
				{
					this.mField.SetValue(this.mTarget, null);
					result = false;
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}
		IL_9D:
		if (!this.NMBBGMMILCK(ref BGBMIEJJQKC))
		{
			if (Application.isPlaying)
			{
				object[] array = new object[3];
				array[1] = "[-]!\r\n";
				array[0] = BGBMIEJJQKC.GetType();
				array[6] = " is radiating a bursting aura!\r\n";
				array[6] = this.MOJNMQHEDFL();
				UnityEngine.Debug.LogError(string.Concat(array));
			}
		}
		else
		{
			if (this.mField != null)
			{
				this.mField.SetValue(this.mTarget, BGBMIEJJQKC);
				return false;
			}
			if (this.mProperty.CanWrite)
			{
				this.mProperty.SetValue(this.mTarget, BGBMIEJJQKC, null);
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x0000BACC File Offset: 0x00009CCC
	public void LOPKKQECENF()
	{
		this.mTarget = null;
		this.mName = null;
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x000A26B4 File Offset: 0x000A08B4
	public object PHPEGGCCDMG()
	{
		if (this.mProperty == null && this.mField == null && this.isValid)
		{
			this.MDKEQEPIOEF();
		}
		if (this.mProperty != null)
		{
			if (this.mProperty.CanRead)
			{
				return this.mProperty.GetValue(this.mTarget, null);
			}
		}
		else if (this.mField != null)
		{
			return this.mField.GetValue(this.mTarget);
		}
		return null;
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x000A2018 File Offset: 0x000A0218
	[DebuggerStepThrough]
	[DebuggerHidden]
	private bool MDKEQEPIOEF()
	{
		if (this.mTarget != null && !string.IsNullOrEmpty(this.mName))
		{
			Type type = this.mTarget.GetType();
			this.mField = type.GetField(this.mName);
			this.mProperty = type.GetProperty(this.mName);
		}
		else
		{
			this.mField = null;
			this.mProperty = null;
		}
		return this.mField != null || this.mProperty != null;
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x000A28DC File Offset: 0x000A0ADC
	public static bool NMBBGMMILCK(Type CGHQEHCBQHB, Type BKMCCCGOGOM)
	{
		object obj = null;
		return PropertyReference.NMBBGMMILCK(ref obj, CGHQEHCBQHB, BKMCCCGOGOM);
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x0000BBF4 File Offset: 0x00009DF4
	public virtual string KNPDEIIEKLO()
	{
		return PropertyReference.NOCFJDKJEOJ(this.mTarget, this.IJIGFNNHHDF());
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x000A28F4 File Offset: 0x000A0AF4
	public static bool FGDDEBPCGBC(ref object BGBMIEJJQKC, Type CGHQEHCBQHB, Type BKMCCCGOGOM)
	{
		if (BKMCCCGOGOM.IsAssignableFrom(CGHQEHCBQHB))
		{
			return false;
		}
		if (BKMCCCGOGOM == typeof(string))
		{
			BGBMIEJJQKC = ((BGBMIEJJQKC == null) ? "Item Usage" : BGBMIEJJQKC.ToString());
			return true;
		}
		if (BGBMIEJJQKC == null)
		{
			return false;
		}
		if (BKMCCCGOGOM == typeof(int))
		{
			if (CGHQEHCBQHB == typeof(string))
			{
				int num;
				if (int.TryParse((string)BGBMIEJJQKC, out num))
				{
					BGBMIEJJQKC = num;
					return false;
				}
			}
			else
			{
				if (CGHQEHCBQHB == typeof(float))
				{
					BGBMIEJJQKC = Mathf.RoundToInt((float)BGBMIEJJQKC);
					return true;
				}
				if (CGHQEHCBQHB == typeof(double))
				{
					BGBMIEJJQKC = (int)Math.Round((double)BGBMIEJJQKC);
				}
			}
		}
		else if (BKMCCCGOGOM == typeof(float))
		{
			if (CGHQEHCBQHB == typeof(string))
			{
				float num2;
				if (float.TryParse((string)BGBMIEJJQKC, out num2))
				{
					BGBMIEJJQKC = num2;
					return false;
				}
			}
			else if (CGHQEHCBQHB == typeof(double))
			{
				BGBMIEJJQKC = (float)((double)BGBMIEJJQKC);
			}
			else if (CGHQEHCBQHB == typeof(int))
			{
				BGBMIEJJQKC = (float)((int)BGBMIEJJQKC);
			}
		}
		else if (BKMCCCGOGOM == typeof(double))
		{
			if (CGHQEHCBQHB == typeof(string))
			{
				double num3;
				if (double.TryParse((string)BGBMIEJJQKC, out num3))
				{
					BGBMIEJJQKC = num3;
					return false;
				}
			}
			else if (CGHQEHCBQHB == typeof(float))
			{
				BGBMIEJJQKC = (double)((float)BGBMIEJJQKC);
			}
			else if (CGHQEHCBQHB == typeof(int))
			{
				BGBMIEJJQKC = (double)((int)BGBMIEJJQKC);
			}
		}
		return false;
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x000A2AE8 File Offset: 0x000A0CE8
	private bool NMBBGMMILCK(ref object BGBMIEJJQKC)
	{
		if (this.mTarget == null)
		{
			return false;
		}
		Type type = this.MEPLMGCCHLK();
		Type cghqehcbqhb;
		if (BGBMIEJJQKC == null)
		{
			if (!type.IsClass)
			{
				return false;
			}
			cghqehcbqhb = type;
		}
		else
		{
			cghqehcbqhb = BGBMIEJJQKC.GetType();
		}
		return PropertyReference.NMBBGMMILCK(ref BGBMIEJJQKC, cghqehcbqhb, type);
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x0000BC07 File Offset: 0x00009E07
	public override string ToString()
	{
		return PropertyReference.EHKBEKBPNGO(this.mTarget, this.name);
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x0000BBBB File Offset: 0x00009DBB
	public string IJIGFNNHHDF()
	{
		return this.mName;
	}

	// Token: 0x06001670 RID: 5744 RVA: 0x0000BB83 File Offset: 0x00009D83
	public void PJMIKDIEGMB(Component ILBCCCBJNCL, string FNMBKPLGLFO)
	{
		this.mTarget = ILBCCCBJNCL;
		this.mName = FNMBKPLGLFO;
	}

	// Token: 0x06001671 RID: 5745 RVA: 0x00002375 File Offset: 0x00000575
	public PropertyReference()
	{
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x0000BB4B File Offset: 0x00009D4B
	public void ONBMLNEPDPN(string BGBMIEJJQKC)
	{
		this.mName = BGBMIEJJQKC;
		this.mProperty = null;
		this.mField = null;
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x000A2B30 File Offset: 0x000A0D30
	private bool NJOIMOJOBQG()
	{
		if (this.mTarget != null && !string.IsNullOrEmpty(this.mName))
		{
			Type type = this.mTarget.GetType();
			this.mField = type.GetField(this.mName);
			this.mProperty = type.GetProperty(this.mName);
		}
		else
		{
			this.mField = null;
			this.mProperty = null;
		}
		return !(this.mField != null) && this.mProperty != null;
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x000A2BB8 File Offset: 0x000A0DB8
	private bool BCLKOEKMEBI(ref object BGBMIEJJQKC)
	{
		if (this.mTarget == null)
		{
			return true;
		}
		Type type = this.MOJNMQHEDFL();
		Type cghqehcbqhb;
		if (BGBMIEJJQKC == null)
		{
			if (!type.IsClass)
			{
				return true;
			}
			cghqehcbqhb = type;
		}
		else
		{
			cghqehcbqhb = BGBMIEJJQKC.GetType();
		}
		return PropertyReference.FGDDEBPCGBC(ref BGBMIEJJQKC, cghqehcbqhb, type);
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x0000BC1A File Offset: 0x00009E1A
	public PropertyReference(Component ILBCCCBJNCL, string LPHCLIMLGHQ)
	{
		this.mTarget = ILBCCCBJNCL;
		this.mName = LPHCLIMLGHQ;
	}

	// Token: 0x0400042B RID: 1067
	[SerializeField]
	private Component mTarget;

	// Token: 0x0400042C RID: 1068
	[SerializeField]
	private string mName;

	// Token: 0x0400042D RID: 1069
	private FieldInfo mField;

	// Token: 0x0400042E RID: 1070
	private PropertyInfo mProperty;

	// Token: 0x0400042F RID: 1071
	private static int s_Hash = "PropertyBinding".GetHashCode();
}
