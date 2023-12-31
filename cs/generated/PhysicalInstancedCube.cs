using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Lumix
{
	[NativeComponent(Type = "physical_instanced_cube")]
	public class PhysicalInstancedCube : Component
	{
		public PhysicalInstancedCube(Entity _entity)
			: base(_entity,  getModule(_entity.instance_, "physical_instanced_cube" )) { }


		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static Vec3 getHalfExtents(IntPtr module, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setHalfExtents(IntPtr module, int cmp, Vec3 value);


		public Vec3 HalfExtents
		{
			get { return getHalfExtents(module_, entity_.entity_Id_); }
			set { setHalfExtents(module_, entity_.entity_Id_, value); }
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int getLayer(IntPtr module, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setLayer(IntPtr module, int cmp, int value);


		public int Layer
		{
			get { return getLayer(module_, entity_.entity_Id_); }
			set { setLayer(module_, entity_.entity_Id_, value); }
		}

	} // class
} // namespace
