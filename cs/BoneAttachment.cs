using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace Lumix
{


	public class BoneAttachment : Component
	{
		private int component_id;
		private IntPtr scene;


		public override void create()
		{
			component_id = create(entity._universe, entity._entity_id, "bone_attachment");
			scene = getScene(entity._universe, "bone_attachment");
		}


		/* Bone */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void setBone(IntPtr scene, int cmp, int source);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static int getBone(IntPtr scene, int cmp);
		
		public int Bone
		{
			get{ return getBone(scene, component_id); }
			set{ setBone(scene, component_id, value); }
		}


		/* Position */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void setPosition(IntPtr scene, int cmp, Vec3 source);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static Vec3 getPosition(IntPtr scene, int cmp);
		
		public Vec3 Position
		{
			get{ return getPosition(scene, component_id); }
			set{ setPosition(scene, component_id, value); }
		}


		/* Rotation */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void setRotation(IntPtr scene, int cmp, Vec3 source);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static Vec3 getRotation(IntPtr scene, int cmp);
		
		public Vec3 Rotation
		{
			get{ return getRotation(scene, component_id); }
			set{ setRotation(scene, component_id, value); }
		}


		/* Parent */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void setParent(IntPtr scene, int cmp, Entity source);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static Entity getParent(IntPtr scene, int cmp);
		
		public Entity Parent
		{
			get{ return getParent(scene, component_id); }
			set{ setParent(scene, component_id, value); }
		}


	}

}