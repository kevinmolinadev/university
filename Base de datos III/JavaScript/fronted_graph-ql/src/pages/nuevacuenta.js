import React, { useState } from "react";
import { useRouter } from "next/router";
import { useFormik } from 'fromik'
import * as Yup from 'yup';
import layaout from "../components/Layaout";
import { useMutation, gql } from "@apollo/client";
import Layaout from "../components/Layaout";


const NUEVA_CUENTA = gql `

    mutation NuevoUsuario($input: UsuarioInput) {
        nuevoUsuario(input: $input) {
            nombre
            apellido
            email
            password
    
        }
    }

`;

const NuevaCuenta = () => {

    //State para el manejo de mensajes
    const [ mensaje, guardarMensaje ] = useState(null);
    //Mutation para crear nuevos usuarios
    const [ nuevoUsuario ] = useMutation(NUEVA_CUENTA);

    //Routing
    const router = useRouter();

    //Validar el formulario con Yup
    const formik = useFormik({
       initialValues: {
           nombre:'',
           apellido: '',
           email: '',
           password: ''
       },
       ValidationSchema: Yup.object({
           nombre: Yup.string()
               .required('El nombre es obligatorio'),
           apellido: Yup.string()
               .required('El apellido es obligatorio'),
           email: Yup.string()
               .email('El email no es válido')
               .required('El email es obligatorio'),
           password: Yup.string
               .required('La contraseña es requerida')
               .min(6, 'El password debe contener minimo seis caracteres'),

       }),
        onSubmit: async valores =>{
           const { nombre, apellido, email, password } = valores;
           try{
               const { data } = await nuevoUsuario({
                   variables: {
                       input: {
                           nombre,
                           apellido,
                           email,
                           password
                       }
                   }
               })
               guardarMensaje(`Usuario creado correctamente: ${data.nombre} ${data.apellido}`);
               setTimeout( () =>{
                   guardarMensaje(null);
                   router.push('/login');


               }, 3000)


           }catch(error){
               guardarMensaje('Error al guardar un nuevo usuario');
               setTimeout(()=>{
                   guardarMensaje(null);
               }, 3000)
           }

        }

    });

    //Retornar los mensajes
    const mostrarMensaje = ()=> {
        return (
          <div className="bg-white py-2 px-3 w-full my-3 max-w-sm text-center mx-auto">
              <p>{mensaje}</p>
          </div>
        );
    }

    return (
      <>
      <Layaout>
          {mensaje && mostrarMensaje()}
          <h1 className= "text-center text-2xl text-white font-light">
              Crear una nueva Cuenta
          </h1>
          <div className="flex justify-center mt-5">
              <div className= "w-full max-w-sm">
                  <form
                      className="bg-white rounded shadow-md px-8 pt-6 pb-8 mb-4" onSubmit={formik.handleSubmit}

                  >
                      <div className="mb-4">
                          <label className= "block text-gray-700 text-sm font-bolt mb-2" htmlFor="nombre">
                              Nombre
                          </label>
                          <input
                              className="shadow appreance-none border rouded text-gray-700"
                              id= "nombre"
                              type= "text"
                              placeholder= "Nombre del Usuario"
                              value={formik.values.nombre}
                              onChange={formik.handleChange}
                              onBlur={formik.handleBlur}
                           />
                      </div>
                          { formik.touched.nombre && formik.errors.nombre ? (
                              <div className= "border-1-4 border-red-500 p-4">
                                  <p className="font-bold">Error</p>
                                  <p>{formik.errors.nombre}</p>
                              </div>

                              ): null

                          }

                      <div className="mb-4">
                          <label className= "block text-gray-700 text-sm font-bolt mb-2" htmlFor="apellido">
                              Apellido
                          </label>
                          <input
                              className="shadow appreance-none border rouded text-gray-700"
                              id= "nombre"
                              type= "text"
                              placeholder= "Apellido del Usuario"
                              value={formik.values.apellido}
                              onChange={formik.handleChange}
                              onBlur={formik.handleBlur}
                          />

                      </div>
                      { formik.touched.nombre && formik.errors.apellido ? (
                          <div className= "border-1-4 border-red-500 p-4">
                              <p className="font-bold">Error</p>
                              <p>{formik.errors.apellido}</p>
                          </div>

                      ): null

                      }

                      <div className="mb-4">
                          <label className= "block text-gray-700 text-sm font-bolt mb-2" htmlFor="email">
                              Email
                          </label>
                          <input
                              className="shadow appreance-none border rouded text-gray-700"
                              id= "nombre"
                              type= "text"
                              placeholder= "Email del Usuario"
                              value={formik.values.email}
                              onChange={formik.handleChange}
                              onBlur={formik.handleBlur}
                          />
                      </div>
                      { formik.touched.nombre && formik.errors.apellido ? (
                          <div className= "border-1-4 border-red-500 p-4">
                              <p className="font-bold">Error</p>
                              <p>{formik.errors.email}</p>
                          </div>

                      ): null

                      }


                      <input
                          type="submit"
                          className="bg-gray-800 w-full mt-5 p-2 text-white uppercase hover:cursor-pointer hover:bg-gray-900"
                          value="Crear Cuenta"
                      />
                  </form>

              </div>
          </div>
      </Layaout>


      </>
    );
}