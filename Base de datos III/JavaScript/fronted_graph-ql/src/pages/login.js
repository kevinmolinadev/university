import { useFormik } from 'fromik'
import * as Yup from 'yup';


const AUTENTICAR_USUARIO = gql `
    mutation AutenticarUsuario($input: AutenticarUsuario) {
        autenticarUsuario(input: $input) {
        token
    }
}
`;

const Login = ()=>{

    const formik = useFormik({
        initalValues: {
            email: '',
            password: '',

        },
        validationSchema: Yup.object({
            email: Yup.string()
                .email('El email no es válido')
                .required('El email no puede estar vacío.'),
            password: Yup.string()
                .required('El password es obligatorio')
        }),
        onSubmit: async valores => {
            const { email, password } = valores;
            try {
                const { data } = await autenticarUsuario({
                    variables: {
                        input: {
                            email,
                            password
                        }
                    }
                });
                //Guardar el token en el localStorage
                setTimeout(() => {
                    guardarMensaje(null);
                    router.push('/');
                }, 2000);


            }catch (error){
                guardarMensaje(error.message);

                setTimeout(() =>{
                    guardarMensaje(null);
                },3000);
            }
        }
    })
}