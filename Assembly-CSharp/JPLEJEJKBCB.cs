using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200003C RID: 60
[AddComponentMenu("NGUI/Examples/Play Idle Animations")]
public class JPLEJEJKBCB : MonoBehaviour
{
	// Token: 0x06000844 RID: 2116 RVA: 0x00057A58 File Offset: 0x00055C58
	private void QNGIFIJOQML()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Overcoat");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == ", ")
					{
						animationState.layer = 0;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("Tilesets/Materials/1"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00057B74 File Offset: 0x00055D74
	private void JDLQNCEDMPI()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Inactive");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "UpS")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("Illusion"))
					{
						animationState.layer = 0;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00057C90 File Offset: 0x00055E90
	private void DKJKOBGBKCN()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(764f, 716f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(409f, 1579f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00057D78 File Offset: 0x00055F78
	private void ECQHGIBBBPI()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + ")");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "Right")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("An electric current runs across the battlefield!\r\n"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00057E94 File Offset: 0x00056094
	private void PIQDBCGQDCH()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(909f, 202f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1361f, 45f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00057F7C File Offset: 0x0005617C
	private void KHFDJHFJMDK()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Right");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "Protects the Pokémon from some ball and bomb moves.")
					{
						animationState.layer = 0;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("You can not use buffs during interactions."))
					{
						animationState.layer = 0;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00058098 File Offset: 0x00056298
	private void BJFCILIPEMI()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1246f, 1296f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1487f, 1874f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00058180 File Offset: 0x00056380
	private void LQIHPQIKEFE()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1340f, 941f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(993f, 1402f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00058268 File Offset: 0x00056468
	private void IGJMLLFDCHM()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(420f, 686f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1295f, 1682f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00058350 File Offset: 0x00056550
	private void NLNIQPOMOGM()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1697f, 234f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1814f, 650f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00058438 File Offset: 0x00056638
	private void MJPQJHEEPMD()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Move Learning");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "Super Repel")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("'s [ffff00]"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00058554 File Offset: 0x00056754
	private void HMJOBKGICKD()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "StopRow3");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "Fresnel")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("[ATK]"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00058670 File Offset: 0x00056870
	private void CMLGQHQJDGQ()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Encounter Rate Increased");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "Chat Box")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith(".psx"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x0005878C File Offset: 0x0005698C
	private void NIIPIECJPOL()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1464f, 75f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1044f, 1533f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00058874 File Offset: 0x00056A74
	private void DHGEJKGNHCO()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "tie");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == " was subjected to torment!\r\n")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("0"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00058990 File Offset: 0x00056B90
	private void QJGNJIIOHMI()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "-end");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "watersport")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("#,##0"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x00058AAC File Offset: 0x00056CAC
	private void IPFJMEFKGGM()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1932f, 1437f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1305f, 914f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00058B94 File Offset: 0x00056D94
	private void HQGDEKJQQDE()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "!");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "_ClipArgs2")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("Anticipates an ally's attack and dodges it."))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00058CB0 File Offset: 0x00056EB0
	private void HDMNIKNDNGQ()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1981f, 1560f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1072f, 1622f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00058D98 File Offset: 0x00056F98
	private void IENJNCIDFNK()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1064f, 1662f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1431f, 1667f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00058E80 File Offset: 0x00057080
	private void CBICBMGFHCP()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(25f, 1411f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(450f, 1405f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00058F68 File Offset: 0x00057168
	private void CPJJKJLFOEN()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "[-]!\r\n");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "You used Sweet Scent recently and are unable to use it again.")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith(" "))
					{
						animationState.layer = 0;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00059084 File Offset: 0x00057284
	private void PNHPFOHOGMC()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(226f, 521f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(999f, 1694f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x0005916C File Offset: 0x0005736C
	private void GCEDFPKOEMN()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(884f, 1171f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(352f, 1863f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x00059254 File Offset: 0x00057454
	private void OGQBIPQNIQD()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Chat Input");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "It cannot be knocked out with one hit. One-hit KO moves cannot knock it out, either.")
					{
						animationState.layer = 0;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith(".prefab"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00059370 File Offset: 0x00057570
	private void DLBNQMKQILC()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1727f, 1318f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(103f, 1032f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00059458 File Offset: 0x00057658
	private void IDIFGIFCEHO()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "_ClipArgs0");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "Score: ")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("b"))
					{
						animationState.layer = 0;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00059574 File Offset: 0x00057774
	private void KIBHJLEBHHF()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1182f, 1026f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1116f, 747f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x0005965C File Offset: 0x0005785C
	private void GCQNFNBMMPQ()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1047f, 1844f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(423f, 392f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00059744 File Offset: 0x00057944
	private void HHLNMNBLHFM()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "magicroom");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "-endability")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("["))
					{
						animationState.layer = 0;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00059860 File Offset: 0x00057A60
	private void FGQGJMDKLOD()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "map:");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "deltastream")
					{
						animationState.layer = 0;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("_FogAreaPosition"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x0005997C File Offset: 0x00057B7C
	private void HFEGBJEPMPQ()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(927f, 1044f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(384f, 913f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00059A64 File Offset: 0x00057C64
	private void LODQBMMKNNM()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Player/Hair");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "'s protection!\r\n")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("perish0"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00059B80 File Offset: 0x00057D80
	private void BBGHCDGEDEJ()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "_");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "CombinersArgsAlphaOp1")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("_Emission"))
					{
						animationState.layer = 0;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00059C9C File Offset: 0x00057E9C
	private void EJCHKLBMECH()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1493f, 69f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1548f, 627f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00059D84 File Offset: 0x00057F84
	private void QFFJMIOJENJ()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1787f, 537f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1612f, 1829f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00059E6C File Offset: 0x0005806C
	private void OLLNOFNEEIL()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "(Q)");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "Score: ")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("-1"))
					{
						animationState.layer = 0;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00059F88 File Offset: 0x00058188
	private void HCHNCCPGFCB()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1727f, 572f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(760f, 1331f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0005A070 File Offset: 0x00058270
	private void Start()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + " has no Animation component");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "idle")
					{
						animationState.layer = 0;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("idle"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x0005A18C File Offset: 0x0005838C
	private void CNIKQOQLFFB()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Player/Hair_");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == " is an Ephemeral Port which is used by TCP/UDP as Source/Outgoing port. This may cause problems!")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("Camera Window"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x0005A2A8 File Offset: 0x000584A8
	private void KHQIGBMDOGP()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1613f, 54f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(508f, 767f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x0005A390 File Offset: 0x00058590
	private void CIHJOEIFMQE()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(30f, 965f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1577f, 592f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x0005A478 File Offset: 0x00058678
	private void MMLKOGQFENF()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "item");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "The Pokémon can poison the target even if it's a Steel or Poison type.")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("u"))
					{
						animationState.layer = 0;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x0005A594 File Offset: 0x00058794
	private void FKFEDINPBFF()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1643f, 569f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1919f, 277f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0005A67C File Offset: 0x0005887C
	private void GKBQDQKLPIM()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1135f, 1362f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(197f, 1728f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x0005A764 File Offset: 0x00058964
	private void IBPJIOLMDLE()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[1];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1579f, 1811f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1339f, 199f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x0005A84C File Offset: 0x00058A4C
	private void GBGEGKHDQKB()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + " can't get it going!\r\n");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "W")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("_LensCoeff"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x0005A968 File Offset: 0x00058B68
	private void FCOIMQGENDB()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "data4");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "Mute")
					{
						animationState.layer = 0;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("[-]"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x0005AA84 File Offset: 0x00058C84
	private void JLBMOKHNDBI()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(1835f, 472f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(579f, 466f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x0005AB6C File Offset: 0x00058D6C
	private void NOBDHBBKKHN()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Poison Point");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "[pok=")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("!\r\n"))
					{
						animationState.layer = 1;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x0005AC88 File Offset: 0x00058E88
	private void FLNFKFECNFJ()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 0)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(206f, 1127f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(1, this.NBNDEPQODDQ.Count - 0);
				if (this.DHKPGDQFENP == num)
				{
					num += 0;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 1;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(1273f, 1602f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x0005AD70 File Offset: 0x00058F70
	private void Update()
	{
		if (this.EQNBGOLDFOL < Time.time)
		{
			if (this.NBNDEPQODDQ.Count == 1)
			{
				AnimationClip animationClip = this.NBNDEPQODDQ[0];
				this.EQNBGOLDFOL = Time.time + animationClip.length + UnityEngine.Random.Range(5f, 15f);
				this.DBJQBEKGFHP.CrossFade(animationClip.name);
			}
			else
			{
				int num = UnityEngine.Random.Range(0, this.NBNDEPQODDQ.Count - 1);
				if (this.DHKPGDQFENP == num)
				{
					num++;
					if (num >= this.NBNDEPQODDQ.Count)
					{
						num = 0;
					}
				}
				this.DHKPGDQFENP = num;
				AnimationClip animationClip2 = this.NBNDEPQODDQ[num];
				this.EQNBGOLDFOL = Time.time + animationClip2.length + UnityEngine.Random.Range(2f, 8f);
				this.DBJQBEKGFHP.CrossFade(animationClip2.name);
			}
		}
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x0005AE58 File Offset: 0x00059058
	private void IJNCFJMGKDE()
	{
		this.DBJQBEKGFHP = base.GetComponentInChildren<Animation>();
		if (this.DBJQBEKGFHP == null)
		{
			Debug.LogWarning(IKBQNBHOJJB.IHLEQHINJKK(base.gameObject) + "Die");
			UnityEngine.Object.Destroy(this);
		}
		else
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (animationState.clip.name == "Language")
					{
						animationState.layer = 1;
						this.GDHQIQPKEPK = animationState.clip;
						this.DBJQBEKGFHP.Play(this.GDHQIQPKEPK.name);
					}
					else if (animationState.clip.name.StartsWith("QCGENKHJDDH"))
					{
						animationState.layer = 0;
						this.NBNDEPQODDQ.Add(animationState.clip);
					}
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			if (this.NBNDEPQODDQ.Count == 0)
			{
				UnityEngine.Object.Destroy(this);
			}
		}
	}

	// Token: 0x04000126 RID: 294
	private Animation DBJQBEKGFHP;

	// Token: 0x04000127 RID: 295
	private AnimationClip GDHQIQPKEPK;

	// Token: 0x04000128 RID: 296
	private List<AnimationClip> NBNDEPQODDQ = new List<AnimationClip>();

	// Token: 0x04000129 RID: 297
	private float EQNBGOLDFOL;

	// Token: 0x0400012A RID: 298
	private int DHKPGDQFENP;
}
