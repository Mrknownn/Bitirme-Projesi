"use client";
import EditorPicksDetailPage from '../page'

const EditorPicksDetail = ({ params }) => {


    if (params.id)
        return <EditorPicksDetailPage id={params.id} />;
};

export default EditorPicksDetail