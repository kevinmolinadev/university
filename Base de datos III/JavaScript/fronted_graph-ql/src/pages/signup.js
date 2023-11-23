import React, { useState } from "react";
import { useRouter } from "next/router";
import { useFormik } from 'formik'
import * as Yup from 'yup';
import Layout from "../components/Layout";
import { useMutation, gql } from "@apollo/client";

const NUEVA_CUENTA = gql`
    mutation Mutation($input: UserInput) {
        newUser(input: $input) {
            id
            name
            last_name
            email
            date_created
          }
    }
`;
const NuevaCuenta = () => {

    //State para el manejo de mensajes
    const [mensaje, guardarMensaje] = useState(null);

    //Mutation para crear nuevos usuarios
    //const [ nuevoUsuario ] = useMutation(NUEVA_CUENTA);

    //Routing
    const router = useRouter();

    //Validar el formulario con Yup
    const formik = useFormik({
        initialValues: {
            nombre: '',
            apellido: '',
            email: '',
            password: ''
        },
        validationSchema: Yup.object({
            nombre: Yup.string()
                .required('El nombre es requerido.'),
            apellido: Yup.string()
                .required('El apellido es requerido.'),
            email: Yup.string()
                .email('El Email no es válido')
                .required('El Email es obligatorio.'),
            password: Yup.string()
                .required('El password es requerido.')
                .min(6, 'El password debe contener mínimo seis caracteres')
        }),
        onSubmit: async valores => {
            const { nombre, apellido, email, password } = valores;
            try {
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
                guardarMensaje(`Usuario creado corréctamente: ${data.nombre} ${data.apellido}`);
                setTimeout(() => {
                    guardarMensaje(null);
                    //router.push('/login');
                }, 3000)
            } catch (error) {
                guardarMensaje(error.message);
                setTimeout(() => {
                    guardarMensaje(null);
                }, 3000)
            }
        }
    });

    //Retornar los mensajes
    const mostrarMensaje = () => {
        return (
            <div className="bg-white py-2 px-3 w-full my-3 max-w-sm text-center mx-auto">
                <p>{mensaje}</p>
            </div>
        );
    }

    return (
        <>
            <Layout>
                {mensaje && mostrarMensaje()}
                <div className="m-auto">
                    <h1 className="text-center text-2xl text-black font-light">Crear un nuevo vendedor</h1>
                    <div className="flex justify-center mt-5">
                        <div className="w-full max-w-sm">
                            <form
                                className="bg-white rounded shadow-md px-8 pt-6 pb-8 mb-4" onSubmit={formik.handleSubmit}
                            >
                                <div className="mb-4">
                                    <label className="block text-gray-700 text-sm font-bolt mb-2" htmlFor="nombre">
                                        Nombre
                                    </label>
                                    <input
                                        className="shadow appereance-none border rouded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                                        id="nombre"
                                        type="text"
                                        placeholder="Nombre del vendedor"
                                        value={formik.values.nombre}
                                        onChange={formik.handleChange}
                                        onBlur={formik.handleBlur}
                                    />
                                </div>
                                {formik.touched.nombre && formik.errors.nombre ? (
                                    <div className="border-1-4 border-red-500 p-4">
                                        <p className="font-bold">Error</p>
                                        <p>{formik.errors.nombre}</p>
                                    </div>
                                ) : null}

                                <div className="mb-4">
                                    <label className="block text-gray-700 text-sm font-bolt mb-2" htmlFor="nombre">
                                        Apellido
                                    </label>
                                    <input
                                        className="shadow appereance-none border rouded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                                        id="apellido"
                                        type="text"
                                        placeholder="Apellido del vendedor"
                                        value={formik.values.apellido}
                                        onChange={formik.handleChange}
                                        onBlur={formik.handleBlur}
                                    />
                                </div>
                                {formik.touched.apellido && formik.errors.apellido ? (
                                    <div className="border-1-4 border-red-500 p-4">
                                        <p className="font-bold">Error</p>
                                        <p>{formik.errors.apellido}</p>
                                    </div>
                                ) : null}

                                <div className="mb-4">
                                    <label className="block text-gray-700 text-sm font-bolt mb-2" htmlFor="nombre">
                                        Email
                                    </label>
                                    <input
                                        className="shadow appereance-none border rouded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                                        id="email"
                                        type="email"
                                        placeholder="E-Mail del vendedor"
                                        value={formik.values.email}
                                        onChange={formik.handleChange}
                                        onBlur={formik.handleBlur}
                                    />
                                </div>
                                {formik.touched.email && formik.errors.email ? (
                                    <div className="border-1-4 border-red-500 p-4">
                                        <p className="font-bold">Error</p>
                                        <p>{formik.errors.email}</p>
                                    </div>
                                ) : null}

                                <div className="mb-4">
                                    <label className="block text-gray-700 text-sm font-bolt mb-2" htmlFor="nombre">
                                        Password
                                    </label>
                                    <input
                                        className="shadow appereance-none border rouded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                                        id="password"
                                        type="password"
                                        placeholder="Password del vendedor"
                                        value={formik.values.password}
                                        onChange={formik.handleChange}
                                        onBlur={formik.handleBlur}
                                    />
                                </div>
                                {formik.touched.password && formik.errors.password ? (
                                    <div className="border-1-4 border-red-500 p-4">
                                        <p className="font-bold">Error</p>
                                        <p>{formik.errors.password}</p>
                                    </div>
                                ) : null}

                                <input
                                    type="submit"
                                    className="bg_gray-800 w-full mt-5 p-2 text-white uppercase hover:cursor-pointer hover:bg-gray-900"
                                    value="Crear Vendedor"
                                />

                            </form>
                        </div>
                    </div>
                </div>
            </Layout>
        </>
    );
}
export default NuevaCuenta;